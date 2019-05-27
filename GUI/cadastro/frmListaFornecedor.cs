using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using DevExpress.XtraGrid.Columns;
using System.Windows.Forms;

namespace ccb_ef6
{
    public partial class frmListaFornecedor : Form
    {
        public frmListaFornecedor()
        {
            InitializeComponent();
        }

        private void DisableButtonsWhenNoCustomers(bool v)
        {
            btnEdit.Enabled = !v;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmNovoOuEditaFornecedor frm = new frmNovoOuEditaFornecedor();

            frm.FormClosed += (s, ev) =>
            {
                frmListaFornecedor_Load(sender, e);
                this.WindowState = FormWindowState.Maximized;
                this.Show();
            };

            frm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            editaFornecedor();
        }

        private void frmListaFornecedor_Load(object sender, EventArgs e)
        {
            List<Fornecedor> FornecedorList = new List<Fornecedor>();

            FornecedorList = FornecedorServices.GetAll();

            //dgvFornecedores.DataSource = FornecedorList;
            dgRegistros.DataSource = FornecedorList;

            foreach (GridColumn col in gvRegistros.Columns)
            {
                switch (col.FieldName)
                {
                    case "Nome":
                    case "Contato_Nome":
                    case "Telefone1":
                    case "Telefone2":
                    case "Email":
                        col.Visible = true;
                        break;
                    default:
                        col.Visible = false;
                        break;
                }
            }

            if (FornecedorList.Count == 0)
            {
                DisableButtonsWhenNoCustomers(true);
            }
            else
            {
                DisableButtonsWhenNoCustomers(false);
            }

            //btnWithdrawal.Visible = Properties.Settings.Default.AllowCashRequest;

            this.WindowState = FormWindowState.Maximized;
        }

        private void editaFornecedor()
        {
            int Linha;

            if (!gvRegistros.IsValidRowHandle(gvRegistros.FocusedRowHandle))
                return;

            Fornecedor Fornecedor = BLL.FornecedorServices.FindById(Convert.ToInt32(gvRegistros.GetRowCellValue(gvRegistros.FocusedRowHandle, "Id")));

            frmNovoOuEditaFornecedor frm = new frmNovoOuEditaFornecedor(Fornecedor);
            frm.Text = "Editar Fornecedor";


            frm.FormClosed += (s, ev) =>
            {
                frmListaFornecedor_Load(null, null);
                this.WindowState = FormWindowState.Maximized;
                this.Show();
            };
            Linha = gvRegistros.FocusedRowHandle;
            frm.ShowDialog();
            dgRegistros.DataSource = BLL.FornecedorServices.FindByFornecedorData(txtTextToFind.Text);

            gvRegistros.FocusedRowHandle = Linha;
        }

        private void gvRegistros_DoubleClick(object sender, EventArgs e)
        {
            editaFornecedor();
        }

        private void txtTextToFind_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                dgRegistros.DataSource = BLL.FornecedorServices.FindByFornecedorData(txtTextToFind.Text);
            if (e.KeyCode == Keys.Down)
                dgRegistros.Focus();
            if (e.KeyCode == Keys.Escape)
            {
                txtTextToFind.Text = "";
                dgRegistros.DataSource = BLL.FornecedorServices.FindByFornecedorData(txtTextToFind.Text);
            }

        }

        private void gvRegistros_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                editaFornecedor();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgRegistros.DataSource = BLL.FornecedorServices.FindByFornecedorData(txtTextToFind.Text);
        }
    }
}
