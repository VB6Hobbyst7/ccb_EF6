using BLL;
using Models;
using System;
using System.Collections.Generic;
using DevExpress.XtraGrid.Columns;
using System.Windows.Forms;

namespace ccb_ef6
{
    public partial class frmListaCliente : Form
    {
        public frmListaCliente()
        {
            InitializeComponent();
        }

        private void DisableButtonsWhenNoClientes(bool v)
        {
            btnEdit.Enabled = !v;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmNovoOuEditaCliente frm = new frmNovoOuEditaCliente();

            frm.FormClosed += (s, ev) =>
            {
                frmListaCliente_Load (sender, e);
                this.WindowState = FormWindowState.Maximized;
                this.Show();
            };

            frm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            editaCliente();
        }

        private void frmListaCliente_Load(object sender, EventArgs e)
        {
            List<Cliente> ClienteList = new List<Cliente>();

            ClienteList = ClienteServices.GetAll();

            //dgvClientes.DataSource = ClienteList;
            dgRegistros.DataSource = ClienteList;

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

            if (ClienteList.Count == 0)
            {
                DisableButtonsWhenNoClientes(true);
            }
            else
            {
                DisableButtonsWhenNoClientes(false);
            }

            //btnWithdrawal.Visible = Properties.Settings.Default.AllowCashRequest;

            this.WindowState = FormWindowState.Maximized;
        }

        private void editaCliente()
        {
            int Linha;


            if (!gvRegistros.IsValidRowHandle(gvRegistros.FocusedRowHandle))
                return;

            Pessoa pessoa = BLL.PessoaServices.FindById(Convert.ToInt32(gvRegistros.GetRowCellValue(gvRegistros.FocusedRowHandle, "Id")));

            frmNovoOuEditaCliente frm = new frmNovoOuEditaCliente(pessoa);
            frm.Text = "Editar cliente";


            frm.FormClosed += (s, ev) =>
            {
                frmListaCliente_Load(null, null);
                this.WindowState = FormWindowState.Maximized;
                this.Show();
            };
            Linha = gvRegistros.FocusedRowHandle;
            frm.ShowDialog();
            dgRegistros.DataSource = BLL.ClienteServices.FindByClienteData(txtTextToFind.Text);

            gvRegistros.FocusedRowHandle = Linha;     
        }

        private void gvRegistros_DoubleClick(object sender, EventArgs e)
        {
            editaCliente();
        }

        private void txtTextToFind_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                dgRegistros.DataSource = BLL.ClienteServices.FindByClienteData(txtTextToFind.Text);
            if (e.KeyCode == Keys.Down)
                dgRegistros.Focus();
            if (e.KeyCode == Keys.Escape)
            {
                txtTextToFind.Text = "";
                dgRegistros.DataSource = BLL.ClienteServices.FindByClienteData(txtTextToFind.Text);
            }

        }

        private void gvRegistros_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                editaCliente();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgRegistros.DataSource = BLL.ClienteServices.FindByClienteData(txtTextToFind.Text);
        }
    }
}
