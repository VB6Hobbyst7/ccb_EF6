using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BLL;
using Models;
using DevExpress.XtraGrid.Columns;

namespace ccb_ef6
{
    public partial class frmListaLinha : DevExpress.XtraEditors.XtraForm
    {
        public frmListaLinha()
        {
            InitializeComponent();
        }

        private void DisableButtonsWhenNoLinhas(bool v)
        {
            btnEdit.Enabled = !v;
        }

        private void frmListaLinha_Load(object sender, EventArgs e)
        {
            List<Linha> LinhaList = new List<Linha>();

            LinhaList = LinhaServices.GetAll();

            dgRegistros.DataSource = LinhaList;

            foreach (GridColumn col in gvRegistros.Columns)
            {
                switch (col.FieldName)
                {
                    case "Codigo":
                    case "Nome":
                    case "Cor":
                    case "Estoque_1":
                    case "Estoque_2":
                    case "Minimo":
                    case "Pedido":
                        col.Visible = true;
                        break;
                    default:
                        col.Visible = false;
                        break;
                }
            }

            if (LinhaList.Count == 0)
            {
                DisableButtonsWhenNoLinhas(true);
            }
            else
            {
                DisableButtonsWhenNoLinhas(false);
            }

            //btnWithdrawal.Visible = Properties.Settings.Default.AllowCashRequest;

            this.WindowState = FormWindowState.Maximized;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmNovoOuEditaLinha frm = new frmNovoOuEditaLinha();

            frm.FormClosed += (s, ev) =>
            {
                frmListaLinha_Load(sender, e);
                this.WindowState = FormWindowState.Maximized;
                this.Show();
            };

            frm.ShowDialog();
        }

        private void editaLinha()
        {
            int row;


            if (!gvRegistros.IsValidRowHandle(gvRegistros.FocusedRowHandle))
                return;

            Linha linha = BLL.LinhaServices.FindById(Convert.ToString(gvRegistros.GetRowCellValue(gvRegistros.FocusedRowHandle, "Codigo")));

            frmNovoOuEditaLinha frm = new frmNovoOuEditaLinha(linha);
            frm.Text = "Editar linha";


            frm.FormClosed += (s, ev) =>
            {
                frmListaLinha_Load(null, null);
                this.WindowState = FormWindowState.Maximized;
                this.Show();
            };
            row = gvRegistros.FocusedRowHandle;
            frm.ShowDialog();
            dgRegistros.DataSource = BLL.LinhaServices.FindByLinhaData(txtTextToFind.Text);

            gvRegistros.FocusedRowHandle = row;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            editaLinha();
        }

        private void gvRegistros_DoubleClick(object sender, EventArgs e)
        {
            editaLinha();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgRegistros.DataSource = BLL.LinhaServices.FindByLinhaData(txtTextToFind.Text);
        }

        private void txtTextToFind_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                dgRegistros.DataSource = BLL.LinhaServices.FindByLinhaData(txtTextToFind.Text);
            if (e.KeyCode == Keys.Down)
                dgRegistros.Focus();
            if (e.KeyCode == Keys.Escape)
            {
                txtTextToFind.Text = "";
                dgRegistros.DataSource = BLL.LinhaServices.FindByLinhaData(txtTextToFind.Text);
            }
        }

        private void gvRegistros_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                editaLinha();
        }
    }
}