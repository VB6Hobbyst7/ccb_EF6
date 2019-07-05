using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using System.ComponentModel.DataAnnotations;
using DevExpress.XtraEditors.ColorWheel;
using DevExpress.LookAndFeel;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraBars.Helpers;
using ccb_ef6;

namespace GUI
{
    public partial class frmPrincipal : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmPrincipal()
        {
            InitializeComponent();

            //DevExpress.UserSkins.BonusSkins.Register();

            SkinHelper.InitSkinGallery(rgbiSkins);

            RibbonButtonsInitialize();

            //CreateColorPopup(popupControlContainer1);
            InitEditors();
            UserLookAndFeel.Default.StyleChanged += new EventHandler(OnLookAndFeelStyleChanged);
            UserLookAndFeel.Default.SetSkinStyle("Office 2013");
            // Icon = DevExpress.Utils.ResourceImageHelper.CreateIconFromResourcesEx("DevExpress.XtraBars.Demos.RibbonSimplePad.AppIcon.ico", typeof(frmPrincipal).Assembly);

        }

        void RibbonButtonsInitialize()
        {
            ribbon.Toolbar.ItemLinks.Add(rgbiSkins);
        }


        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            SplashScreenManager.CloseForm(false);
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
        }
        void OnLookAndFeelStyleChanged(object sender, EventArgs e)
        {
            UpdateSchemeCombo();
        }
        private void InitSchemeCombo()
        {
            foreach (object obj in Enum.GetValues(typeof(RibbonControlColorScheme)))
            {
                repositoryItemComboBox1.Items.Add(obj);
            }
            beScheme.EditValue = RibbonControlColorScheme.Yellow;
        }

        public void MostraAgaurde(string caption, string description)
        {
            SplashScreenManager.ShowDefaultWaitForm(caption, description);
        }

        public void OcultaAguarde()
        {
            try
            {
                SplashScreenManager.CloseForm();
            }
            catch { }

        }

        private void SelecionaTab(String tab)
        {
            foreach (DevExpress.XtraTabbedMdi.XtraMdiTabPage pag in xtraTabbedMdiManager1.Pages)
            {
                if (pag.Text == tab) xtraTabbedMdiManager1.SelectedPage = pag;
            }
        }


        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            //gridControl.ShowRibbonPrintPreview();
        }

        public class Customer
        {
            [Key, Display(AutoGenerateField = false)]
            public int ID { get; set; }
            [Required]
            public string Name { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            [Display(Name = "Zip Code")]
            public string ZipCode { get; set; }
            public string Phone { get; set; }
        }

        private void rgbiFont_Gallery_ItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {

        }

        private void rgbiFontColor_Gallery_ItemClick(object sender, DevExpress.XtraBars.Ribbon.GalleryItemClickEventArgs e)
        {

        }

        private void gddFontColor_Gallery_CustomDrawItemImage(object sender, DevExpress.XtraBars.Ribbon.GalleryItemCustomDrawEventArgs e)
        {

        }

        private void bbColorMix_ItemClick(object sender, ItemClickEventArgs e)
        {
            ColorWheelForm form = new ColorWheelForm();
            form.StartPosition = FormStartPosition.CenterParent;
            form.SkinMaskColor = UserLookAndFeel.Default.SkinMaskColor;
            form.SkinMaskColor2 = UserLookAndFeel.Default.SkinMaskColor2;
            form.ShowDialog(this);
        }

        private void iExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void bbColorMix_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            ColorWheelForm form = new ColorWheelForm();
            form.StartPosition = FormStartPosition.CenterParent;
            form.SkinMaskColor = UserLookAndFeel.Default.SkinMaskColor;
            form.SkinMaskColor2 = UserLookAndFeel.Default.SkinMaskColor2;
            form.ShowDialog(this);
        }

        private void biStyle_EditValueChanged(object sender, EventArgs e)
        {
            RibbonControlStyle style = (RibbonControlStyle)biStyle.EditValue;
            ribbon.RibbonStyle = style;
            if (style == RibbonControlStyle.Office2010 || style == RibbonControlStyle.MacOffice || style == RibbonControlStyle.Office2013 || style == RibbonControlStyle.TabletOffice || style == RibbonControlStyle.OfficeUniversal)
            {
                //ribbon.ApplicationButtonDropDownControl = this.backstageViewControl1;
            }
            else
            {
                ribbon.ApplicationButtonDropDownControl = pmAppMain;
            }
            if (style == RibbonControlStyle.TabletOffice || style == RibbonControlStyle.OfficeUniversal)
            {
                this.barToggleSwitchItem1.Visibility = BarItemVisibility.Always;
            }
            else
            {
                this.barToggleSwitchItem1.Visibility = BarItemVisibility.Never;
            }
            UpdateSchemeCombo();
            UpdateLookAndFeel();
        }
        void UpdateLookAndFeel()
        {
            string skinName;
            RibbonControlStyle style = ribbon.RibbonStyle;
            switch (style)
            {
                case RibbonControlStyle.Default:
                case RibbonControlStyle.Office2007:
                    skinName = "Office 2007 Blue";
                    break;
                case RibbonControlStyle.Office2013:
                case RibbonControlStyle.TabletOffice:
                case RibbonControlStyle.OfficeUniversal:
                    skinName = "Office 2013";
                    break;
                case RibbonControlStyle.Office2010:
                case RibbonControlStyle.MacOffice:
                default:
                    skinName = "Office 2010 Blue";
                    break;
            }
            UserLookAndFeel.Default.SetSkinStyle(skinName);
        }
        void UpdateSchemeCombo()
        {
            if (ribbon.RibbonStyle == RibbonControlStyle.MacOffice ||
                ribbon.RibbonStyle == RibbonControlStyle.Office2010 || ribbon.RibbonStyle == RibbonControlStyle.Office2013)
            {
                beScheme.Visibility = UserLookAndFeel.Default.ActiveSkinName.Contains("Office 2010") ? BarItemVisibility.Always : BarItemVisibility.Never;
            }
            else
            {
                beScheme.Visibility = BarItemVisibility.Never;
            }
        }

        private void beScheme_EditValueChanged(object sender, EventArgs e)
        {
            ribbon.ColorScheme = ((RibbonControlColorScheme)beScheme.EditValue);
        }

        void InitEditors()
        {
            riicStyle.Items.Add(new ImageComboBoxItem("Office 2007", RibbonControlStyle.Office2007, -1));
            riicStyle.Items.Add(new ImageComboBoxItem("Office 2010", RibbonControlStyle.Office2010, -1));
            riicStyle.Items.Add(new ImageComboBoxItem("Office 2013", RibbonControlStyle.Office2013, -1));
            riicStyle.Items.Add(new ImageComboBoxItem("MacOffice", RibbonControlStyle.MacOffice, -1));
            riicStyle.Items.Add(new ImageComboBoxItem("TabletOffice", RibbonControlStyle.TabletOffice, -1));
            riicStyle.Items.Add(new ImageComboBoxItem("OfficeUniversal", RibbonControlStyle.OfficeUniversal, -1));
            biStyle.EditValue = ribbon.RibbonStyle;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            if (GUI.Properties.Settings.Default.Conectado == true)
                sbUsuario.Caption = GUI.Properties.Settings.Default.Usuario;

            if (GUI.Properties.Settings.Default.BDTeste == true)
            {
                this.Text = "T E S T E";
            }
            else
            {
                this.Text = "ccb";
            }
            String pele;

            try
            {
                Microsoft.Win32.RegistryKey regKey = Microsoft.Win32.Registry.CurrentUser.OpenSubKey("Software\\ccb4");
                pele = regKey.GetValue("Skin").ToString();
            }
            catch
            {
                pele = "Visual Studio 2013 Blue";
            }

            UserLookAndFeel.Default.SetSkinStyle(pele);
            Application.EnableVisualStyles();

            //InitMostRecentFiles();
            //arMRUList = new MRUArrayList(pcAppMenuFileLabels, imageCollection3.Images[0], imageCollection3.Images[1]);
            //arMRUList.LabelClicked += new EventHandler(OnMRUFileLabelClicked);
            //InitMostRecentFiles(arMRUList);
            ribbon.ForceInitialize();
            GalleryDropDown skins = new GalleryDropDown();
            skins.Ribbon = ribbon;
            DevExpress.XtraBars.Helpers.SkinHelper.InitSkinGalleryDropDown(skins);
            iPaintStyle.DropDownControl = skins;

            //CreateNewDocument();
            //barEditItem1.EditValue = (Bitmap)DevExpress.Utils.ResourceImageHelper.CreateImageFromResources("DevExpress.XtraBars.Demos.RibbonSimplePad.online.gif", typeof(frmPrincipal).Assembly);

        }

        private void iExit_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void idNew_ItemClick(object sender, ItemClickEventArgs e)
        {

            MostraAgaurde("Aguarde", "Abrindo o formulário...");
            OcultaAguarde();
        }

        private void btnPedido_ItemClick(object sender, ItemClickEventArgs e)
        {
            MostraAgaurde("Aguarde", "Abrindo o formulário...");
            OcultaAguarde();
        }

        private void btnBordado_ItemClick(object sender, ItemClickEventArgs e)
        {
            MostraAgaurde("Aguarde", "Abrindo o formulário...");
            frmListaBordado frm = new frmListaBordado
            {
                MdiParent = this
            };
            frm.Show();
            OcultaAguarde();
        }

        private void btnCliente_ItemClick(object sender, ItemClickEventArgs e)
        {
            MostraAgaurde("Aguarde", "Abrindo o formulário...");
            frmListaFornecedor frm = new frmListaFornecedor
            {
                MdiParent = this
            };
            frm.Show();
            OcultaAguarde();
        }

        private void btnFornecedor_ItemClick(object sender, ItemClickEventArgs e)
        {
            MostraAgaurde("Aguarde", "Abrindo o formulário...");

        }

        private void btnEmpregado_ItemClick(object sender, ItemClickEventArgs e)
        {
            MostraAgaurde("Aguarde", "Abrindo o formulário...");
            frmCustomerList frm = new frmCustomerList
            {
                MdiParent = this
            };
            frm.Show();

            OcultaAguarde();
        }

        private void btngrupo_ItemClick(object sender, ItemClickEventArgs e)
        {
            MostraAgaurde("Aguarde", "Abrindo o formulário...");
            OcultaAguarde();
        }

        private void btnLinha_ItemClick(object sender, ItemClickEventArgs e)
        {
            MostraAgaurde("Aguarde", "Abrindo o formulário...");
            frmListaLinha frm = new frmListaLinha
            {
                MdiParent = this
            };
            frm.Show();
            OcultaAguarde();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Guarda no registro
            Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\\ccb4");

            key.SetValue("Style", biStyle.EditValue);
            key.SetValue("Skin", UserLookAndFeel.Default.SkinName.ToString());

        }

        private void btnAgendaPedido_ItemClick(object sender, ItemClickEventArgs e)
        {
            MostraAgaurde("Aguarde", "Abrindo o formulário...");
            OcultaAguarde();
        }

        private void btnPreferencias_ItemClick(object sender, ItemClickEventArgs e)
        {
            MostraAgaurde("Aguarde", "Abrindo o formulário...");
            OcultaAguarde();
        }

        private void btnAgendaCriacao_ItemClick(object sender, ItemClickEventArgs e)
        {
            MostraAgaurde("Aguarde", "Abrindo o formulário...");
            OcultaAguarde();
        }

        private void btnCalculaTotalPedido_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnEstatisticaPedido_ItemClick(object sender, ItemClickEventArgs e)
        {
            MostraAgaurde("Aguarde", "Abrindo o formulário...");

            OcultaAguarde();
        }
    }
}