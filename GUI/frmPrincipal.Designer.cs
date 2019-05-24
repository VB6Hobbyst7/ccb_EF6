using DevExpress.XtraBars.Ribbon;
namespace GUI
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup1 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup2 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
            DevExpress.Utils.SuperToolTip superToolTip2 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipTitleItem toolTipTitleItem2 = new DevExpress.Utils.ToolTipTitleItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.iOpen = new DevExpress.XtraBars.BarButtonItem();
            this.iSave = new DevExpress.XtraBars.BarButtonItem();
            this.iUndo = new DevExpress.XtraBars.BarButtonItem();
            this.iReplace = new DevExpress.XtraBars.BarButtonItem();
            this.idNew = new DevExpress.XtraBars.BarButtonItem();
            this.iClose = new DevExpress.XtraBars.BarButtonItem();
            this.iSaveAs = new DevExpress.XtraBars.BarButtonItem();
            this.iPrint = new DevExpress.XtraBars.BarButtonItem();
            this.iExit = new DevExpress.XtraBars.BarButtonItem();
            this.iCut = new DevExpress.XtraBars.BarButtonItem();
            this.iCopy = new DevExpress.XtraBars.BarButtonItem();
            this.iPaste = new DevExpress.XtraBars.BarButtonItem();
            this.iClear = new DevExpress.XtraBars.BarButtonItem();
            this.iSelectAll = new DevExpress.XtraBars.BarButtonItem();
            this.iFind = new DevExpress.XtraBars.BarButtonItem();
            this.iFont = new DevExpress.XtraBars.BarButtonItem();
            this.iBullets = new DevExpress.XtraBars.BarButtonItem();
            this.iProtected = new DevExpress.XtraBars.BarButtonItem();
            this.iWeb = new DevExpress.XtraBars.BarButtonItem();
            this.iBold = new DevExpress.XtraBars.BarButtonItem();
            this.iItalic = new DevExpress.XtraBars.BarButtonItem();
            this.iUnderline = new DevExpress.XtraBars.BarButtonItem();
            this.iAlignLeft = new DevExpress.XtraBars.BarButtonItem();
            this.iCenter = new DevExpress.XtraBars.BarButtonItem();
            this.iAlignRight = new DevExpress.XtraBars.BarButtonItem();
            this.iFontColor = new DevExpress.XtraBars.BarButtonItem();
            this.sbRegistros = new DevExpress.XtraBars.BarButtonItem();
            this.siDocName = new DevExpress.XtraBars.BarStaticItem();
            this.bgFontStyle = new DevExpress.XtraBars.BarButtonGroup();
            this.bgAlign = new DevExpress.XtraBars.BarButtonGroup();
            this.bgFont = new DevExpress.XtraBars.BarButtonGroup();
            this.bgBullets = new DevExpress.XtraBars.BarButtonGroup();
            this.sbiSave = new DevExpress.XtraBars.BarSubItem();
            this.sbiPaste = new DevExpress.XtraBars.BarSubItem();
            this.iPasteSpecial = new DevExpress.XtraBars.BarButtonItem();
            this.sbiFind = new DevExpress.XtraBars.BarSubItem();
            this.iNew = new DevExpress.XtraBars.BarButtonItem();
            this.iLargeUndo = new DevExpress.XtraBars.BarLargeButtonItem();
            this.iTemplate = new DevExpress.XtraBars.BarButtonItem();
            this.iPaintStyle = new DevExpress.XtraBars.BarButtonItem();
            this.beiFontSize = new DevExpress.XtraBars.BarEditItem();
            this.rgbiFont = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.bbiFontColorPopup = new DevExpress.XtraBars.BarButtonItem();
            this.rgbiFontColor = new DevExpress.XtraBars.RibbonGalleryBarItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.editButtonGroup = new DevExpress.XtraBars.BarButtonGroup();
            this.barToggleSwitchItem1 = new DevExpress.XtraBars.BarToggleSwitchItem();
            this.bbColorMix = new DevExpress.XtraBars.BarButtonItem();
            this.biStyle = new DevExpress.XtraBars.BarEditItem();
            this.riicStyle = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.btnPedido = new DevExpress.XtraBars.BarButtonItem();
            this.btnBordado = new DevExpress.XtraBars.BarButtonItem();
            this.btnCliente = new DevExpress.XtraBars.BarButtonItem();
            this.btnFornecedor = new DevExpress.XtraBars.BarButtonItem();
            this.btnEmpregado = new DevExpress.XtraBars.BarButtonItem();
            this.btnLinha = new DevExpress.XtraBars.BarButtonItem();
            this.btngrupo = new DevExpress.XtraBars.BarButtonItem();
            this.sbUsuario = new DevExpress.XtraBars.BarStaticItem();
            this.beScheme = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox2 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.rgbiSkins = new DevExpress.XtraBars.SkinRibbonGalleryBarItem();
            this.txtAviso = new DevExpress.XtraBars.BarStaticItem();
            this.btnAgendaPedido = new DevExpress.XtraBars.BarButtonItem();
            this.btnAgendaCriacao = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.btnPreferencias = new DevExpress.XtraBars.BarButtonItem();
            this.btnCalculaTotalPedido = new DevExpress.XtraBars.BarButtonItem();
            this.btnEstatisticaPedido = new DevExpress.XtraBars.BarButtonItem();
            this.rbpProc = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbpgAtendimento = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpCadastro = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbpgBordado = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpgTabelas = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpUtilitario = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rbpgAparencia = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpgConfiguracao = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rbpgUtiliario = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            this.barEditItem3 = new DevExpress.XtraBars.BarEditItem();
            this.ribbonPageCategory1 = new DevExpress.XtraBars.Ribbon.RibbonPageCategory();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.imageCollection2 = new DevExpress.Utils.ImageCollection(this.components);
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.pmMain = new DevExpress.XtraBars.PopupMenu(this.components);
            this.imageCollection3 = new DevExpress.Utils.ImageCollection(this.components);
            this.pmAppMain = new DevExpress.XtraBars.Ribbon.ApplicationMenu(this.components);
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riicStyle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmAppMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.AllowCustomization = true;
            this.ribbon.ApplicationButtonText = null;
            this.ribbon.AutoSaveLayoutToXml = true;
            this.ribbon.AutoSaveLayoutToXmlPath = "ccbSettings.xml";
            this.ribbon.AutoSizeItems = true;
            this.ribbon.Categories.AddRange(new DevExpress.XtraBars.BarManagerCategory[] {
            new DevExpress.XtraBars.BarManagerCategory("File", new System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f")),
            new DevExpress.XtraBars.BarManagerCategory("Edit", new System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1")),
            new DevExpress.XtraBars.BarManagerCategory("Format", new System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258")),
            new DevExpress.XtraBars.BarManagerCategory("Help", new System.Guid("e07a4c24-66ac-4de6-bbcb-c0b6cfa7798b")),
            new DevExpress.XtraBars.BarManagerCategory("Status", new System.Guid("77795bb7-9bc5-4dd2-a297-cc758682e23d"))});
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.ExpandCollapseItem.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.iOpen,
            this.iSave,
            this.iUndo,
            this.iReplace,
            this.idNew,
            this.iClose,
            this.iSaveAs,
            this.iPrint,
            this.iExit,
            this.iCut,
            this.iCopy,
            this.iPaste,
            this.iClear,
            this.iSelectAll,
            this.iFind,
            this.iFont,
            this.iBullets,
            this.iProtected,
            this.iWeb,
            this.iBold,
            this.iItalic,
            this.iUnderline,
            this.iAlignLeft,
            this.iCenter,
            this.iAlignRight,
            this.iFontColor,
            this.sbRegistros,
            this.siDocName,
            this.bgFontStyle,
            this.bgAlign,
            this.bgFont,
            this.bgBullets,
            this.sbiSave,
            this.sbiPaste,
            this.sbiFind,
            this.iPasteSpecial,
            this.iNew,
            this.iLargeUndo,
            this.iTemplate,
            this.iPaintStyle,
            this.beiFontSize,
            this.rgbiFont,
            this.bbiFontColorPopup,
            this.rgbiFontColor,
            this.barEditItem1,
            this.editButtonGroup,
            this.barToggleSwitchItem1,
            this.bbColorMix,
            this.biStyle,
            this.btnPedido,
            this.btnBordado,
            this.btnCliente,
            this.btnFornecedor,
            this.btnEmpregado,
            this.btnLinha,
            this.btngrupo,
            this.sbUsuario,
            this.beScheme,
            this.rgbiSkins,
            this.txtAviso,
            this.btnAgendaPedido,
            this.btnAgendaCriacao,
            this.barButtonItem1,
            this.barButtonItem2,
            this.btnPreferencias,
            this.btnCalculaTotalPedido,
            this.btnEstatisticaPedido});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbon.MaxItemId = 439;
            this.ribbon.Name = "ribbon";
            this.ribbon.OptionsTouch.ShowTouchUISelectorInQAT = true;
            this.ribbon.OptionsTouch.ShowTouchUISelectorVisibilityItemInQATMenu = true;
            this.ribbon.PageCategoryAlignment = DevExpress.XtraBars.Ribbon.RibbonPageCategoryAlignment.Right;
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbpProc,
            this.rbpCadastro,
            this.rbpUtilitario});
            this.ribbon.QuickToolbarItemLinks.Add(this.btnPedido);
            this.ribbon.QuickToolbarItemLinks.Add(this.btnBordado);
            this.ribbon.QuickToolbarItemLinks.Add(this.btnCliente);
            this.ribbon.QuickToolbarItemLinks.Add(this.btnAgendaPedido);
            this.ribbon.QuickToolbarItemLinks.Add(this.btnAgendaCriacao);
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riicStyle,
            this.repositoryItemComboBox1,
            this.repositoryItemComboBox2});
            this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.MacOffice;
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.Size = new System.Drawing.Size(1173, 130);
            this.ribbon.StatusBar = this.ribbonStatusBar1;
            this.ribbon.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.True;
            // 
            // iOpen
            // 
            this.iOpen.Caption = "&Open...";
            this.iOpen.CategoryGuid = new System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f");
            this.iOpen.Description = "Opens a file.";
            this.iOpen.Hint = "Open a file";
            this.iOpen.Id = 1;
            this.iOpen.ImageOptions.ImageIndex = 7;
            this.iOpen.ImageOptions.LargeImageIndex = 9;
            this.iOpen.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O));
            this.iOpen.Name = "iOpen";
            this.iOpen.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // iSave
            // 
            this.iSave.Caption = "&Save";
            this.iSave.CategoryGuid = new System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f");
            this.iSave.Description = "Saves the active document with its current file name.";
            this.iSave.Hint = "Saves the active document with its current file name";
            this.iSave.Id = 3;
            this.iSave.ImageOptions.ImageIndex = 10;
            this.iSave.ImageOptions.LargeImageIndex = 7;
            this.iSave.Name = "iSave";
            this.iSave.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // iUndo
            // 
            this.iUndo.Caption = "&Undo";
            this.iUndo.CategoryGuid = new System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1");
            this.iUndo.Description = "Reverses the last command or deletes the last entry you typed.";
            this.iUndo.Hint = "Undo";
            this.iUndo.Id = 8;
            this.iUndo.ImageOptions.ImageIndex = 11;
            this.iUndo.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z));
            this.iUndo.Name = "iUndo";
            // 
            // iReplace
            // 
            this.iReplace.Caption = "R&eplace...";
            this.iReplace.CategoryGuid = new System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1");
            this.iReplace.Description = "Searches for and replaces the specified text.";
            this.iReplace.Hint = "Replace";
            this.iReplace.Id = 15;
            this.iReplace.ImageOptions.ImageIndex = 14;
            this.iReplace.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H));
            this.iReplace.Name = "iReplace";
            // 
            // idNew
            // 
            this.idNew.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.idNew.Caption = "New";
            this.idNew.CategoryGuid = new System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f");
            this.idNew.Description = "Creates a new, blank file.";
            this.idNew.Hint = "Creates a new, blank file";
            this.idNew.Id = 0;
            this.idNew.ImageOptions.ImageIndex = 6;
            this.idNew.ImageOptions.LargeImageIndex = 0;
            this.idNew.Name = "idNew";
            this.idNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.idNew_ItemClick);
            // 
            // iClose
            // 
            this.iClose.Caption = "&Close";
            this.iClose.CategoryGuid = new System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f");
            this.iClose.Description = "Closes the active document.";
            this.iClose.Hint = "Closes the active document";
            this.iClose.Id = 2;
            this.iClose.ImageOptions.ImageIndex = 12;
            this.iClose.ImageOptions.LargeImageIndex = 8;
            this.iClose.Name = "iClose";
            this.iClose.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // iSaveAs
            // 
            this.iSaveAs.Caption = "Save &As...";
            this.iSaveAs.CategoryGuid = new System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f");
            this.iSaveAs.Description = "Saves the active document with a different file name.";
            this.iSaveAs.Hint = "Saves the active document with a different file name";
            this.iSaveAs.Id = 4;
            this.iSaveAs.ImageOptions.ImageIndex = 21;
            this.iSaveAs.ImageOptions.LargeImageIndex = 2;
            this.iSaveAs.Name = "iSaveAs";
            // 
            // iPrint
            // 
            this.iPrint.Caption = "&Print";
            this.iPrint.CategoryGuid = new System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f");
            this.iPrint.Description = "Prints the active document.";
            this.iPrint.Hint = "Prints the active document";
            this.iPrint.Id = 5;
            this.iPrint.ImageOptions.ImageIndex = 9;
            this.iPrint.ImageOptions.LargeImageIndex = 6;
            this.iPrint.Name = "iPrint";
            this.iPrint.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // iExit
            // 
            this.iExit.Caption = "E&xit";
            this.iExit.CategoryGuid = new System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f");
            this.iExit.Description = "Closes this program after prompting you to save unsaved document.";
            this.iExit.Hint = "Closes this program after prompting you to save unsaved document.";
            this.iExit.Id = 6;
            this.iExit.ImageOptions.ImageIndex = 22;
            this.iExit.ImageOptions.LargeImageIndex = 1;
            this.iExit.Name = "iExit";
            this.iExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.iExit_ItemClick_1);
            // 
            // iCut
            // 
            this.iCut.Caption = "Cu&t";
            this.iCut.CategoryGuid = new System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1");
            this.iCut.Description = "Removes the selection from the active document and places it on the Clipboard.";
            this.iCut.Hint = "Cut";
            this.iCut.Id = 9;
            this.iCut.ImageOptions.ImageIndex = 2;
            this.iCut.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X));
            this.iCut.Name = "iCut";
            // 
            // iCopy
            // 
            this.iCopy.Caption = "&Copy";
            this.iCopy.CategoryGuid = new System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1");
            this.iCopy.Description = "Copies the selection to the Clipboard.";
            this.iCopy.Hint = "Copy";
            this.iCopy.Id = 10;
            this.iCopy.ImageOptions.ImageIndex = 1;
            this.iCopy.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C));
            this.iCopy.Name = "iCopy";
            // 
            // iPaste
            // 
            this.iPaste.Caption = "&Paste";
            this.iPaste.CategoryGuid = new System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1");
            this.iPaste.Description = "Inserts the contents of the Clipboard at the insertion point, and replaces any se" +
    "lection. This command is available only if you have cut or copied a text.";
            this.iPaste.Hint = "Paste";
            this.iPaste.Id = 11;
            this.iPaste.ImageOptions.ImageIndex = 8;
            this.iPaste.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V));
            this.iPaste.Name = "iPaste";
            // 
            // iClear
            // 
            this.iClear.Caption = "Cle&ar";
            this.iClear.CategoryGuid = new System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1");
            this.iClear.Description = "Deletes the selected text without putting it on the Clipboard. This command is av" +
    "ailable only if a text is selected. ";
            this.iClear.Hint = "Clear";
            this.iClear.Id = 12;
            this.iClear.ImageOptions.ImageIndex = 13;
            this.iClear.Name = "iClear";
            // 
            // iSelectAll
            // 
            this.iSelectAll.Caption = "Select A&ll";
            this.iSelectAll.CategoryGuid = new System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1");
            this.iSelectAll.Description = "Selects all text in the active document.";
            this.iSelectAll.Hint = "Selects all text in the active document.";
            this.iSelectAll.Id = 13;
            this.iSelectAll.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A));
            this.iSelectAll.Name = "iSelectAll";
            // 
            // iFind
            // 
            this.iFind.Caption = "&Find...";
            this.iFind.CategoryGuid = new System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1");
            this.iFind.Description = "Searches for the specified text.";
            this.iFind.Hint = "Find";
            this.iFind.Id = 14;
            this.iFind.ImageOptions.ImageIndex = 3;
            this.iFind.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F));
            this.iFind.Name = "iFind";
            // 
            // iFont
            // 
            this.iFont.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.iFont.Caption = "&Font...";
            this.iFont.CategoryGuid = new System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258");
            this.iFont.Description = "Changes the font and character spacing formats of the selected text.";
            this.iFont.Hint = "Font Dialog";
            this.iFont.Id = 17;
            this.iFont.ImageOptions.ImageIndex = 4;
            this.iFont.Name = "iFont";
            this.iFont.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText;
            // 
            // iBullets
            // 
            this.iBullets.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.iBullets.Caption = "&Bullets";
            this.iBullets.CategoryGuid = new System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258");
            this.iBullets.Description = "Adds bullets to or removes bullets from selected paragraphs.";
            this.iBullets.Hint = "Bullets";
            this.iBullets.Id = 18;
            this.iBullets.ImageOptions.ImageIndex = 0;
            this.iBullets.Name = "iBullets";
            // 
            // iProtected
            // 
            this.iProtected.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.iProtected.Caption = "P&rotected";
            this.iProtected.CategoryGuid = new System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258");
            this.iProtected.Description = "Protects the selected text.";
            this.iProtected.Hint = "Protects the selected text";
            this.iProtected.Id = 19;
            this.iProtected.Name = "iProtected";
            // 
            // iWeb
            // 
            this.iWeb.Caption = "&DevExpress on the Web";
            this.iWeb.CategoryGuid = new System.Guid("e07a4c24-66ac-4de6-bbcb-c0b6cfa7798b");
            this.iWeb.Description = "Opens the web page.";
            this.iWeb.Hint = "DevExpress on the Web";
            this.iWeb.Id = 21;
            this.iWeb.ImageOptions.ImageIndex = 24;
            this.iWeb.Name = "iWeb";
            // 
            // iBold
            // 
            this.iBold.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.iBold.Caption = "&Bold";
            this.iBold.CategoryGuid = new System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258");
            this.iBold.Description = "Makes selected text and numbers bold. If the selection is already bold, clicking " +
    "button removes bold formatting.";
            this.iBold.Hint = "Bold";
            this.iBold.Id = 24;
            this.iBold.ImageOptions.ImageIndex = 15;
            this.iBold.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B));
            this.iBold.Name = "iBold";
            // 
            // iItalic
            // 
            this.iItalic.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.iItalic.Caption = "&Italic";
            this.iItalic.CategoryGuid = new System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258");
            this.iItalic.Description = "Makes selected text and numbers italic. If the selection is already italic, click" +
    "ing button removes italic formatting.";
            this.iItalic.Hint = "Italic";
            this.iItalic.Id = 25;
            this.iItalic.ImageOptions.ImageIndex = 16;
            this.iItalic.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I));
            this.iItalic.Name = "iItalic";
            // 
            // iUnderline
            // 
            this.iUnderline.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.iUnderline.Caption = "&Underline";
            this.iUnderline.CategoryGuid = new System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258");
            this.iUnderline.Description = "Underlines selected text and numbers. If the selection is already underlined, cli" +
    "cking button removes underlining.";
            this.iUnderline.Hint = "Underline";
            this.iUnderline.Id = 26;
            this.iUnderline.ImageOptions.ImageIndex = 17;
            this.iUnderline.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U));
            this.iUnderline.Name = "iUnderline";
            // 
            // iAlignLeft
            // 
            this.iAlignLeft.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.iAlignLeft.Caption = "Align &Left";
            this.iAlignLeft.CategoryGuid = new System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258");
            this.iAlignLeft.Description = "Aligns the selected text to the left.";
            this.iAlignLeft.GroupIndex = 1;
            this.iAlignLeft.Hint = "Align Left";
            this.iAlignLeft.Id = 27;
            this.iAlignLeft.ImageOptions.ImageIndex = 18;
            this.iAlignLeft.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L));
            this.iAlignLeft.Name = "iAlignLeft";
            // 
            // iCenter
            // 
            this.iCenter.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.iCenter.Caption = "&Center";
            this.iCenter.CategoryGuid = new System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258");
            this.iCenter.Description = "Centers the selected text.";
            this.iCenter.GroupIndex = 1;
            this.iCenter.Hint = "Center";
            this.iCenter.Id = 28;
            this.iCenter.ImageOptions.ImageIndex = 19;
            this.iCenter.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E));
            this.iCenter.Name = "iCenter";
            // 
            // iAlignRight
            // 
            this.iAlignRight.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.iAlignRight.Caption = "Align &Right";
            this.iAlignRight.CategoryGuid = new System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258");
            this.iAlignRight.Description = "Aligns the selected text to the right.";
            this.iAlignRight.GroupIndex = 1;
            this.iAlignRight.Hint = "Align Right";
            this.iAlignRight.Id = 29;
            this.iAlignRight.ImageOptions.ImageIndex = 20;
            this.iAlignRight.ItemShortcut = new DevExpress.XtraBars.BarShortcut((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R));
            this.iAlignRight.Name = "iAlignRight";
            // 
            // iFontColor
            // 
            this.iFontColor.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.iFontColor.Caption = "Font C&olor";
            this.iFontColor.CategoryGuid = new System.Guid("d3052f28-4b3e-4bae-b581-b3bb1c432258");
            this.iFontColor.Description = "Formats the selected text with the color you click.";
            this.iFontColor.Hint = "Font Color";
            this.iFontColor.Id = 30;
            this.iFontColor.ImageOptions.ImageIndex = 5;
            this.iFontColor.Name = "iFontColor";
            // 
            // sbRegistros
            // 
            this.sbRegistros.CategoryGuid = new System.Guid("77795bb7-9bc5-4dd2-a297-cc758682e23d");
            this.sbRegistros.Id = 0;
            this.sbRegistros.Name = "sbRegistros";
            // 
            // siDocName
            // 
            this.siDocName.CategoryGuid = new System.Guid("77795bb7-9bc5-4dd2-a297-cc758682e23d");
            this.siDocName.Id = 2;
            this.siDocName.Name = "siDocName";
            // 
            // bgFontStyle
            // 
            this.bgFontStyle.Caption = "FontStyle";
            this.bgFontStyle.Id = 0;
            this.bgFontStyle.ItemLinks.Add(this.iBold);
            this.bgFontStyle.ItemLinks.Add(this.iItalic);
            this.bgFontStyle.ItemLinks.Add(this.iUnderline);
            this.bgFontStyle.Name = "bgFontStyle";
            this.bgFontStyle.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.True;
            // 
            // bgAlign
            // 
            this.bgAlign.Caption = "Align";
            this.bgAlign.Id = 0;
            this.bgAlign.ItemLinks.Add(this.iAlignLeft);
            this.bgAlign.ItemLinks.Add(this.iCenter);
            this.bgAlign.ItemLinks.Add(this.iAlignRight);
            this.bgAlign.Name = "bgAlign";
            this.bgAlign.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.True;
            // 
            // bgFont
            // 
            this.bgFont.Caption = "Font";
            this.bgFont.Id = 0;
            this.bgFont.ItemLinks.Add(this.iFont);
            this.bgFont.ItemLinks.Add(this.iFontColor);
            this.bgFont.Name = "bgFont";
            this.bgFont.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.True;
            // 
            // bgBullets
            // 
            this.bgBullets.Caption = "Bullets";
            this.bgBullets.Id = 1;
            this.bgBullets.ItemLinks.Add(this.iBullets);
            this.bgBullets.ItemLinks.Add(this.iProtected);
            this.bgBullets.Name = "bgBullets";
            this.bgBullets.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.True;
            // 
            // sbiSave
            // 
            this.sbiSave.Caption = "Save";
            this.sbiSave.CategoryGuid = new System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f");
            this.sbiSave.Description = "Saves the active document";
            this.sbiSave.Hint = "Saves the active document";
            this.sbiSave.Id = 0;
            this.sbiSave.ImageOptions.ImageIndex = 10;
            this.sbiSave.ImageOptions.LargeImageIndex = 2;
            this.sbiSave.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.iSave),
            new DevExpress.XtraBars.LinkPersistInfo(this.iSaveAs)});
            this.sbiSave.MenuCaption = "Save";
            this.sbiSave.Name = "sbiSave";
            this.sbiSave.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.True;
            // 
            // sbiPaste
            // 
            this.sbiPaste.Caption = "Paste";
            this.sbiPaste.CategoryGuid = new System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1");
            this.sbiPaste.Description = "Inserts the contents of the Clipboard at the insertion point";
            this.sbiPaste.Hint = "Inserts the contents of the Clipboard at the insertion point";
            this.sbiPaste.Id = 1;
            this.sbiPaste.ImageOptions.ImageIndex = 8;
            this.sbiPaste.ImageOptions.LargeImageIndex = 3;
            this.sbiPaste.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.iPaste),
            new DevExpress.XtraBars.LinkPersistInfo(this.iPasteSpecial)});
            this.sbiPaste.MenuCaption = "Paste";
            this.sbiPaste.Name = "sbiPaste";
            this.sbiPaste.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.True;
            // 
            // iPasteSpecial
            // 
            this.iPasteSpecial.Caption = "Paste &Special...";
            this.iPasteSpecial.CategoryGuid = new System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1");
            this.iPasteSpecial.Description = "Opens the Paste Special dialog";
            this.iPasteSpecial.Enabled = false;
            this.iPasteSpecial.Hint = "Opens the Paste Special dialog";
            this.iPasteSpecial.Id = 3;
            this.iPasteSpecial.ImageOptions.ImageIndex = 8;
            this.iPasteSpecial.Name = "iPasteSpecial";
            // 
            // sbiFind
            // 
            this.sbiFind.Caption = "Find";
            this.sbiFind.CategoryGuid = new System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1");
            this.sbiFind.Description = "Searches for the specified text";
            this.sbiFind.Hint = "Searches for the specified text";
            this.sbiFind.Id = 2;
            this.sbiFind.ImageOptions.ImageIndex = 3;
            this.sbiFind.ImageOptions.LargeImageIndex = 4;
            this.sbiFind.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.iFind),
            new DevExpress.XtraBars.LinkPersistInfo(this.iReplace)});
            this.sbiFind.MenuCaption = "Find and Replace";
            this.sbiFind.Name = "sbiFind";
            this.sbiFind.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.sbiFind.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.True;
            // 
            // iNew
            // 
            this.iNew.Caption = "&New";
            this.iNew.CategoryGuid = new System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f");
            this.iNew.Description = "Creates a new, blank file.";
            this.iNew.Hint = "Creates a new, blank file";
            this.iNew.Id = 0;
            this.iNew.ImageOptions.ImageIndex = 6;
            this.iNew.ImageOptions.LargeImageIndex = 0;
            this.iNew.Name = "iNew";
            // 
            // iLargeUndo
            // 
            this.iLargeUndo.Caption = "&Undo";
            this.iLargeUndo.CategoryGuid = new System.Guid("7c2486e1-92ea-4293-ad55-b819f61ff7f1");
            this.iLargeUndo.Hint = "Undo";
            this.iLargeUndo.Id = 0;
            this.iLargeUndo.ImageOptions.ImageIndex = 11;
            this.iLargeUndo.ImageOptions.LargeImageIndex = 5;
            this.iLargeUndo.Name = "iLargeUndo";
            // 
            // iTemplate
            // 
            this.iTemplate.Caption = "Template...";
            this.iTemplate.CategoryGuid = new System.Guid("4b511317-d784-42ba-b4ed-0d2a746d6c1f");
            this.iTemplate.Description = "Creates a new template";
            this.iTemplate.Enabled = false;
            this.iTemplate.Hint = "Creates a new template";
            this.iTemplate.Id = 1;
            this.iTemplate.ImageOptions.ImageIndex = 6;
            this.iTemplate.Name = "iTemplate";
            // 
            // iPaintStyle
            // 
            this.iPaintStyle.ActAsDropDown = true;
            this.iPaintStyle.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.iPaintStyle.Caption = "Paint style";
            this.iPaintStyle.Description = "Select a paint scheme";
            this.iPaintStyle.Hint = "Select a paint scheme";
            this.iPaintStyle.Id = 7;
            this.iPaintStyle.ImageOptions.ImageIndex = 26;
            this.iPaintStyle.Name = "iPaintStyle";
            // 
            // beiFontSize
            // 
            this.beiFontSize.Caption = "Font Size";
            this.beiFontSize.Edit = null;
            this.beiFontSize.Hint = "Font Size";
            this.beiFontSize.Id = 27;
            this.beiFontSize.Name = "beiFontSize";
            // 
            // rgbiFont
            // 
            this.rgbiFont.Caption = "Font";
            // 
            // 
            // 
            galleryItemGroup1.Caption = "Main";
            this.rgbiFont.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup1});
            this.rgbiFont.Gallery.ImageSize = new System.Drawing.Size(40, 40);
            this.rgbiFont.Gallery.ItemClick += new DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(this.rgbiFont_Gallery_ItemClick);
            this.rgbiFont.Id = 29;
            this.rgbiFont.Name = "rgbiFont";
            // 
            // bbiFontColorPopup
            // 
            this.bbiFontColorPopup.ActAsDropDown = true;
            this.bbiFontColorPopup.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.bbiFontColorPopup.Caption = "Font Color";
            this.bbiFontColorPopup.Description = "Formats the selected text with the color you click";
            this.bbiFontColorPopup.Hint = "Formats the selected text with the color you click";
            this.bbiFontColorPopup.Id = 36;
            this.bbiFontColorPopup.Name = "bbiFontColorPopup";
            // 
            // rgbiFontColor
            // 
            this.rgbiFontColor.Caption = "Color";
            // 
            // 
            // 
            this.rgbiFontColor.Gallery.ColumnCount = 10;
            galleryItemGroup2.Caption = "Main";
            this.rgbiFontColor.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup2});
            this.rgbiFontColor.Gallery.ImageSize = new System.Drawing.Size(20, 14);
            this.rgbiFontColor.Gallery.ItemClick += new DevExpress.XtraBars.Ribbon.GalleryItemClickEventHandler(this.rgbiFontColor_Gallery_ItemClick);
            this.rgbiFontColor.Gallery.CustomDrawItemImage += new DevExpress.XtraBars.Ribbon.GalleryItemCustomDrawEventHandler(this.gddFontColor_Gallery_CustomDrawItemImage);
            this.rgbiFontColor.Id = 37;
            this.rgbiFontColor.Name = "rgbiFontColor";
            // 
            // barEditItem1
            // 
            this.barEditItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barEditItem1.CanOpenEdit = false;
            this.barEditItem1.Edit = null;
            this.barEditItem1.EditWidth = 130;
            this.barEditItem1.Id = 94;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // editButtonGroup
            // 
            this.editButtonGroup.Id = 145;
            this.editButtonGroup.ItemLinks.Add(this.iCut);
            this.editButtonGroup.ItemLinks.Add(this.iCopy);
            this.editButtonGroup.ItemLinks.Add(this.iPaste);
            this.editButtonGroup.ItemLinks.Add(this.iClear);
            this.editButtonGroup.Name = "editButtonGroup";
            this.editButtonGroup.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.True;
            // 
            // barToggleSwitchItem1
            // 
            this.barToggleSwitchItem1.Caption = "Auto Save";
            this.barToggleSwitchItem1.Id = 213;
            this.barToggleSwitchItem1.Name = "barToggleSwitchItem1";
            this.barToggleSwitchItem1.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // bbColorMix
            // 
            this.bbColorMix.Caption = "&Misturar as Cores";
            this.bbColorMix.Id = 238;
            this.bbColorMix.ImageOptions.LargeImageIndex = 0;
            this.bbColorMix.Name = "bbColorMix";
            this.bbColorMix.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbColorMix_ItemClick_1);
            // 
            // biStyle
            // 
            this.biStyle.Caption = "Estilo";
            this.biStyle.Edit = this.riicStyle;
            this.biStyle.EditWidth = 110;
            this.biStyle.Id = 412;
            this.biStyle.Name = "biStyle";
            this.biStyle.EditValueChanged += new System.EventHandler(this.biStyle_EditValueChanged);
            // 
            // riicStyle
            // 
            this.riicStyle.AutoHeight = false;
            this.riicStyle.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riicStyle.Name = "riicStyle";
            // 
            // btnPedido
            // 
            this.btnPedido.Caption = "Pedido";
            this.btnPedido.Id = 11;
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPedido_ItemClick);
            // 
            // btnBordado
            // 
            this.btnBordado.Caption = "Bordado";
            this.btnBordado.Id = 418;
            this.btnBordado.Name = "btnBordado";
            toolTipTitleItem1.Text = "Bordados";
            superToolTip1.Items.Add(toolTipTitleItem1);
            this.btnBordado.SuperTip = superToolTip1;
            this.btnBordado.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBordado_ItemClick);
            // 
            // btnCliente
            // 
            this.btnCliente.Caption = "Cliente";
            this.btnCliente.Id = 419;
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCliente_ItemClick);
            // 
            // btnFornecedor
            // 
            this.btnFornecedor.Caption = "Fornecedor";
            this.btnFornecedor.Id = 420;
            this.btnFornecedor.Name = "btnFornecedor";
            this.btnFornecedor.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            toolTipTitleItem2.Text = "Fornecedor";
            superToolTip2.Items.Add(toolTipTitleItem2);
            this.btnFornecedor.SuperTip = superToolTip2;
            this.btnFornecedor.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFornecedor_ItemClick);
            // 
            // btnEmpregado
            // 
            this.btnEmpregado.Caption = "Empregado";
            this.btnEmpregado.Id = 421;
            this.btnEmpregado.Name = "btnEmpregado";
            this.btnEmpregado.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEmpregado_ItemClick);
            // 
            // btnLinha
            // 
            this.btnLinha.Caption = "Linha";
            this.btnLinha.Id = 422;
            this.btnLinha.Name = "btnLinha";
            this.btnLinha.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLinha_ItemClick);
            // 
            // btngrupo
            // 
            this.btngrupo.Caption = "Grupo";
            this.btngrupo.Id = 423;
            this.btngrupo.Name = "btngrupo";
            this.btngrupo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btngrupo_ItemClick);
            // 
            // sbUsuario
            // 
            this.sbUsuario.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.sbUsuario.Caption = "Não Logado";
            this.sbUsuario.Id = 424;
            this.sbUsuario.Name = "sbUsuario";
            // 
            // beScheme
            // 
            this.beScheme.Edit = this.repositoryItemComboBox2;
            this.beScheme.Id = 425;
            this.beScheme.Name = "beScheme";
            // 
            // repositoryItemComboBox2
            // 
            this.repositoryItemComboBox2.AutoHeight = false;
            this.repositoryItemComboBox2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox2.Name = "repositoryItemComboBox2";
            // 
            // rgbiSkins
            // 
            this.rgbiSkins.Caption = "Tema";
            this.rgbiSkins.Id = 1;
            this.rgbiSkins.Name = "rgbiSkins";
            // 
            // txtAviso
            // 
            this.txtAviso.Id = 428;
            this.txtAviso.Name = "txtAviso";
            // 
            // btnAgendaPedido
            // 
            this.btnAgendaPedido.Caption = "Agenda (P)";
            this.btnAgendaPedido.Id = 429;
            this.btnAgendaPedido.Name = "btnAgendaPedido";
            this.btnAgendaPedido.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAgendaPedido_ItemClick);
            // 
            // btnAgendaCriacao
            // 
            this.btnAgendaCriacao.Caption = "Agenda (C)";
            this.btnAgendaCriacao.Id = 430;
            this.btnAgendaCriacao.Name = "btnAgendaCriacao";
            this.btnAgendaCriacao.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnAgendaCriacao_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 433;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 434;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // btnPreferencias
            // 
            this.btnPreferencias.Caption = "Preferências";
            this.btnPreferencias.Id = 435;
            this.btnPreferencias.Name = "btnPreferencias";
            this.btnPreferencias.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPreferencias_ItemClick);
            // 
            // btnCalculaTotalPedido
            // 
            this.btnCalculaTotalPedido.Caption = "Calcula Total de Pedidos";
            this.btnCalculaTotalPedido.Id = 437;
            this.btnCalculaTotalPedido.Name = "btnCalculaTotalPedido";
            this.btnCalculaTotalPedido.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCalculaTotalPedido_ItemClick);
            // 
            // btnEstatisticaPedido
            // 
            this.btnEstatisticaPedido.Caption = "Estatíst.Pedido";
            this.btnEstatisticaPedido.Id = 438;
            this.btnEstatisticaPedido.Name = "btnEstatisticaPedido";
            this.btnEstatisticaPedido.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEstatisticaPedido_ItemClick);
            // 
            // rbpProc
            // 
            this.rbpProc.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbpgAtendimento});
            this.rbpProc.Name = "rbpProc";
            this.rbpProc.Text = "Processamento";
            // 
            // rbpgAtendimento
            // 
            this.rbpgAtendimento.AllowTextClipping = false;
            this.rbpgAtendimento.ItemLinks.Add(this.btnPedido);
            this.rbpgAtendimento.ItemLinks.Add(this.btnAgendaPedido);
            this.rbpgAtendimento.ItemLinks.Add(this.btnAgendaCriacao);
            this.rbpgAtendimento.Name = "rbpgAtendimento";
            this.rbpgAtendimento.Text = "Atendimento";
            // 
            // rbpCadastro
            // 
            this.rbpCadastro.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbpgBordado,
            this.rbpgTabelas});
            this.rbpCadastro.Name = "rbpCadastro";
            this.rbpCadastro.Text = "Cadastro";
            // 
            // rbpgBordado
            // 
            this.rbpgBordado.ItemLinks.Add(this.btnBordado);
            this.rbpgBordado.ItemLinks.Add(this.btnCliente);
            this.rbpgBordado.ItemLinks.Add(this.btnFornecedor);
            this.rbpgBordado.ItemLinks.Add(this.btnEmpregado);
            this.rbpgBordado.ItemLinks.Add(this.btnLinha);
            this.rbpgBordado.Name = "rbpgBordado";
            this.rbpgBordado.Text = "Cadastros";
            // 
            // rbpgTabelas
            // 
            this.rbpgTabelas.AllowTextClipping = false;
            this.rbpgTabelas.ItemLinks.Add(this.btngrupo);
            this.rbpgTabelas.Name = "rbpgTabelas";
            this.rbpgTabelas.Text = "Tabelas";
            // 
            // rbpUtilitario
            // 
            this.rbpUtilitario.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rbpgAparencia,
            this.rbpgConfiguracao,
            this.rbpgUtiliario});
            this.rbpUtilitario.Name = "rbpUtilitario";
            this.rbpUtilitario.Text = "Utilitário";
            // 
            // rbpgAparencia
            // 
            this.rbpgAparencia.ItemLinks.Add(this.rgbiSkins);
            this.rbpgAparencia.ItemLinks.Add(this.bbColorMix);
            this.rbpgAparencia.ItemLinks.Add(this.biStyle);
            this.rbpgAparencia.Name = "rbpgAparencia";
            this.rbpgAparencia.ShowCaptionButton = false;
            this.rbpgAparencia.Text = "Aparência";
            // 
            // rbpgConfiguracao
            // 
            this.rbpgConfiguracao.ItemLinks.Add(this.btnPreferencias);
            this.rbpgConfiguracao.Name = "rbpgConfiguracao";
            this.rbpgConfiguracao.Text = "Configuração";
            // 
            // rbpgUtiliario
            // 
            this.rbpgUtiliario.ItemLinks.Add(this.btnCalculaTotalPedido);
            this.rbpgUtiliario.ItemLinks.Add(this.btnEstatisticaPedido);
            this.rbpgUtiliario.Name = "rbpgUtiliario";
            this.rbpgUtiliario.Text = "Utilitários";
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.sbRegistros);
            this.ribbonStatusBar1.ItemLinks.Add(this.siDocName, true);
            this.ribbonStatusBar1.ItemLinks.Add(this.barEditItem1);
            this.ribbonStatusBar1.ItemLinks.Add(this.sbUsuario);
            this.ribbonStatusBar1.ItemLinks.Add(this.txtAviso);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 568);
            this.ribbonStatusBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbon;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(1173, 31);
            // 
            // barEditItem2
            // 
            this.barEditItem2.Edit = null;
            this.barEditItem2.EditWidth = 75;
            this.barEditItem2.Id = 188;
            this.barEditItem2.Name = "barEditItem2";
            // 
            // barEditItem3
            // 
            this.barEditItem3.Edit = null;
            this.barEditItem3.EditWidth = 75;
            this.barEditItem3.Hint = "Ribbon Style";
            this.barEditItem3.Id = 106;
            this.barEditItem3.Name = "barEditItem3";
            // 
            // ribbonPageCategory1
            // 
            this.ribbonPageCategory1.Name = "ribbonPageCategory1";
            this.ribbonPageCategory1.Text = "Selection";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Selection";
            // 
            // imageCollection2
            // 
            this.imageCollection2.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection2.ImageStream")));
            this.imageCollection2.Images.SetKeyName(29, "SaveAs_16x16.png");
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(32, 32);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            // 
            // pmMain
            // 
            this.pmMain.ItemLinks.Add(this.iUndo);
            this.pmMain.ItemLinks.Add(this.iCopy, true);
            this.pmMain.ItemLinks.Add(this.iCut);
            this.pmMain.ItemLinks.Add(this.iPaste);
            this.pmMain.ItemLinks.Add(this.iClear);
            this.pmMain.ItemLinks.Add(this.iSelectAll);
            this.pmMain.ItemLinks.Add(this.iFont, true);
            this.pmMain.ItemLinks.Add(this.iBullets);
            this.pmMain.MenuCaption = "Edit Menu";
            this.pmMain.MultiColumn = DevExpress.Utils.DefaultBoolean.True;
            this.pmMain.Name = "pmMain";
            this.pmMain.OptionsMultiColumn.ShowItemText = DevExpress.Utils.DefaultBoolean.True;
            this.pmMain.Ribbon = this.ribbon;
            // 
            // imageCollection3
            // 
            this.imageCollection3.ImageSize = new System.Drawing.Size(15, 15);
            this.imageCollection3.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection3.ImageStream")));
            // 
            // pmAppMain
            // 
            this.pmAppMain.ItemLinks.Add(this.idNew);
            this.pmAppMain.ItemLinks.Add(this.iOpen);
            this.pmAppMain.ItemLinks.Add(this.sbiSave, true);
            this.pmAppMain.ItemLinks.Add(this.iPrint);
            this.pmAppMain.ItemLinks.Add(this.iClose, true);
            this.pmAppMain.Name = "pmAppMain";
            this.pmAppMain.Ribbon = this.ribbon;
            this.pmAppMain.ShowNavigationHeader = DevExpress.Utils.DefaultBoolean.True;
            this.pmAppMain.ShowRightPane = true;
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 599);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "frmPrincipal";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "ccb";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riicStyle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmAppMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.BarButtonItem iOpen;
        private DevExpress.XtraBars.BarButtonItem iSave;
        private DevExpress.XtraBars.BarButtonItem iUndo;
        private DevExpress.XtraBars.BarButtonItem iReplace;
        private DevExpress.XtraBars.BarButtonItem idNew;
        private DevExpress.XtraBars.BarButtonItem iClose;
        private DevExpress.XtraBars.BarButtonItem iSaveAs;
        private DevExpress.XtraBars.BarButtonItem iPrint;
        private DevExpress.XtraBars.BarButtonItem iExit;
        private DevExpress.XtraBars.BarButtonItem iCut;
        private DevExpress.XtraBars.BarButtonItem iCopy;
        private DevExpress.XtraBars.BarButtonItem iPaste;
        private DevExpress.XtraBars.BarButtonItem iClear;
        private DevExpress.XtraBars.BarButtonItem iSelectAll;
        private DevExpress.XtraBars.BarButtonItem iFind;
        private DevExpress.XtraBars.BarButtonItem iFont;
        private DevExpress.XtraBars.BarButtonItem iBullets;
        private DevExpress.XtraBars.BarButtonItem iProtected;
        private DevExpress.XtraBars.BarButtonItem iWeb;
        private DevExpress.XtraBars.BarButtonItem iBold;
        private DevExpress.XtraBars.BarButtonItem iItalic;
        private DevExpress.XtraBars.BarButtonItem iUnderline;
        private DevExpress.XtraBars.BarButtonItem iAlignLeft;
        private DevExpress.XtraBars.BarButtonItem iCenter;
        private DevExpress.XtraBars.BarButtonItem iAlignRight;
        private DevExpress.XtraBars.BarButtonItem iFontColor;
        private DevExpress.XtraBars.BarStaticItem siDocName;
        private DevExpress.XtraBars.BarButtonGroup bgFontStyle;
        private DevExpress.XtraBars.BarButtonGroup bgAlign;
        private DevExpress.XtraBars.BarButtonGroup bgFont;
        private DevExpress.XtraBars.BarButtonGroup bgBullets;
        private DevExpress.XtraBars.BarSubItem sbiSave;
        private DevExpress.XtraBars.BarSubItem sbiPaste;
        private DevExpress.XtraBars.BarButtonItem iPasteSpecial;
        private DevExpress.XtraBars.BarSubItem sbiFind;
        private DevExpress.XtraBars.BarButtonItem iNew;
        private DevExpress.XtraBars.BarLargeButtonItem iLargeUndo;
        private DevExpress.XtraBars.BarButtonItem iTemplate;
        private DevExpress.XtraBars.BarButtonItem iPaintStyle;
        private DevExpress.XtraBars.BarEditItem beiFontSize;
        private DevExpress.XtraBars.RibbonGalleryBarItem rgbiFont;
        private DevExpress.XtraBars.BarButtonItem bbiFontColorPopup;
        private DevExpress.XtraBars.RibbonGalleryBarItem rgbiFontColor;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraBars.BarButtonGroup editButtonGroup;
        private DevExpress.XtraBars.BarToggleSwitchItem barToggleSwitchItem1;
        private DevExpress.XtraBars.BarButtonItem bbColorMix;
        private DevExpress.XtraBars.Ribbon.RibbonPage rbpUtilitario;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rbpgAparencia;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.BarEditItem barEditItem2;
        private DevExpress.XtraBars.BarEditItem barEditItem3;
        private DevExpress.XtraBars.Ribbon.RibbonPageCategory ribbonPageCategory1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.BarEditItem biStyle;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox riicStyle;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private RibbonPage rbpProc;
        private RibbonPageGroup rbpgAtendimento;
        private DevExpress.XtraBars.BarButtonItem btnPedido;
        public DevExpress.XtraBars.BarButtonItem sbRegistros;
        private RibbonPage rbpCadastro;
        private RibbonPageGroup rbpgBordado;
        private DevExpress.XtraBars.BarButtonItem btnBordado;
        private DevExpress.XtraBars.BarButtonItem btnCliente;
        private DevExpress.XtraBars.BarButtonItem btnFornecedor;
        private DevExpress.XtraBars.BarButtonItem btnEmpregado;
        private DevExpress.XtraBars.BarButtonItem btnLinha;
        private DevExpress.XtraBars.BarButtonItem btngrupo;
        private RibbonPageGroup rbpgTabelas;
        private DevExpress.XtraBars.BarStaticItem sbUsuario;
        private DevExpress.XtraBars.BarEditItem beScheme;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox2;
        private DevExpress.XtraBars.SkinRibbonGalleryBarItem rgbiSkins;
        private DevExpress.XtraBars.BarStaticItem txtAviso;
        private DevExpress.XtraBars.BarButtonItem btnAgendaPedido;
        private DevExpress.XtraBars.BarButtonItem btnAgendaCriacao;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem btnPreferencias;
        private RibbonPageGroup rbpgConfiguracao;
        private DevExpress.XtraBars.BarButtonItem btnCalculaTotalPedido;
        private RibbonPageGroup rbpgUtiliario;
        private DevExpress.XtraBars.BarButtonItem btnEstatisticaPedido;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.Utils.ImageCollection imageCollection2;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraBars.PopupMenu pmMain;
        private DevExpress.Utils.ImageCollection imageCollection3;
        private ApplicationMenu pmAppMain;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}