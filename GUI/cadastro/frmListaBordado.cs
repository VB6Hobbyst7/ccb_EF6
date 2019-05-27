using BLL;
using Models;
using System;
using System.Collections.Generic;
using DevExpress.XtraGrid.Columns;
using System.Windows.Forms;

namespace ccb_ef6
{
    public partial class frmListaBordado : Form
    {
        public frmListaBordado()
        {
            InitializeComponent();
        }

        private void DisableButtonsWhenNoBordados(bool v)
        {
            btnEdit.Enabled = !v;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmNovoOuEditaBordado frm = new frmNovoOuEditaBordado();

            frm.FormClosed += (s, ev) =>
            {
                frmListaBordado_Load(sender, e);
                this.WindowState = FormWindowState.Maximized;
                this.Show();
            };

            frm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            editaBordado();
        }

        private void frmListaBordado_Load(object sender, EventArgs e)
        {
            List<Bordado> BordadoList = new List<Bordado>();

            BordadoList = BordadoServices.GetAll();

            //dgvBordados.DataSource = BordadoList;
            dgRegistros.DataSource = BordadoList;

            foreach (GridColumn col in gvRegistros.Columns)
            {
                switch (col.FieldName)
                {
                    case "Arquivo":
                    case "Caminho":
                    case "Pontos":
                    case "Cores":
                    case "Largura":
                    case "Altura":
                        col.Visible = true;
                        break;
                    default:
                        col.Visible = false;
                        break;
                }
            }

            if (BordadoList.Count == 0)
            {
                DisableButtonsWhenNoBordados(true);
            }
            else
            {
                DisableButtonsWhenNoBordados(false);
            }

            //btnWithdrawal.Visible = Properties.Settings.Default.AllowCashRequest;

            this.WindowState = FormWindowState.Maximized;
        }

        private void editaBordado()
        {
            int Linha;


            if (!gvRegistros.IsValidRowHandle(gvRegistros.FocusedRowHandle))
                return;

            Bordado Bordado = BLL.BordadoServices.FindById(Convert.ToInt32(gvRegistros.GetRowCellValue(gvRegistros.FocusedRowHandle, "Id")));

            frmNovoOuEditaBordado frm = new frmNovoOuEditaBordado(Bordado);
            frm.Text = "Editar Bordado";


            frm.FormClosed += (s, ev) =>
            {
                frmListaBordado_Load(null, null);
                this.WindowState = FormWindowState.Maximized;
                this.Show();
            };
            Linha = gvRegistros.FocusedRowHandle;
            frm.ShowDialog();
            dgRegistros.DataSource = BLL.BordadoServices.FindByBordadoData(txtTextToFind.Text);

            gvRegistros.FocusedRowHandle = Linha;
        }

        private void gvRegistros_DoubleClick(object sender, EventArgs e)
        {
            editaBordado();
        }

        private void txtTextToFind_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                dgRegistros.DataSource = BLL.BordadoServices.FindByBordadoData(txtTextToFind.Text);
            if (e.KeyCode == Keys.Down)
                dgRegistros.Focus();
            if (e.KeyCode == Keys.Escape)
            {
                txtTextToFind.Text = "";
                dgRegistros.DataSource = BLL.BordadoServices.FindByBordadoData(txtTextToFind.Text);
            }

        }

        private void gvRegistros_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                editaBordado();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgRegistros.DataSource = BLL.BordadoServices.FindByBordadoData(txtTextToFind.Text);
        }
    }
}
