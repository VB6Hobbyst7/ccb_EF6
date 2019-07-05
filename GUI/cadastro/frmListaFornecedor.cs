using Models;
using System;
using System.Collections.Generic;
using DevExpress.XtraGrid.Columns;
using System.Windows.Forms;
using Repository;
using BLL;

namespace ccb_ef6
{
    public partial class frmListaFornecedor : Form
    {
        //protected Service_ccb _service;

        public frmListaFornecedor()
        {
            InitializeComponent();
            //_service = new Service_ccb();
        }

        private void DisableButtonsWhenNoClientes(bool v)
        {
            btnEdit.Enabled = !v;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmNovoOuEditaFornecedor frm = new frmNovoOuEditaFornecedor();

            frm.FormClosed += (s, ev) =>
            {
                frmListaFornecedor_Load (sender, e);
                this.WindowState = FormWindowState.Maximized;
                this.Show();
            };
            frm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            editaFornecedor();
        }

        private void CarregaRegistros()
        {
            IEnumerable<FornecedorModel> PessoaList = new List<FornecedorModel>();

            PessoaList = FornecedorModel.RecuperarLista();

            dgRegistros.DataSource = PessoaList;

            if (PessoaList == null)
            {
                DisableButtonsWhenNoClientes(true);
            }
            else
            {
                DisableButtonsWhenNoClientes(false);
            }
        }

        private void editaFornecedor()
        {
            int Linha;


            if (!gvRegistros.IsValidRowHandle(gvRegistros.FocusedRowHandle))
                return;
             
            int id = Convert.ToInt32(gvRegistros.GetRowCellValue(gvRegistros.FocusedRowHandle, "Id"));
            //var pessoa = _service.ObterPorIdPessoa(guid);
            var pessoa = PessoaServices.FindById(id);

            //PessoaViewModel pessoa = _service.ObterPorIdPessoa (guid);

            frmNovoOuEditaFornecedor frm = new frmNovoOuEditaFornecedor(pessoa);
            frm.Text = "Editar cliente";


            frm.FormClosed += (s, ev) =>
            {
                frmListaFornecedor_Load(null, null);
                this.WindowState = FormWindowState.Maximized;
                this.Show();
            };
            Linha = gvRegistros.FocusedRowHandle;
            frm.ShowDialog();
            //dgRegistros.DataSource = BLL.ClienteServices.FindByClienteData(txtTextToFind.Text);
            CarregaRegistros();

            gvRegistros.FocusedRowHandle = Linha;     
        }

        private void gvRegistros_DoubleClick(object sender, EventArgs e)
        {
            editaFornecedor();
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
                editaFornecedor();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dgRegistros.DataSource = BLL.ClienteServices.FindByClienteData(txtTextToFind.Text);
        }

        private void frmListaFornecedor_Load(object sender, EventArgs e)
        {
            CarregaRegistros();

            foreach (GridColumn col in gvRegistros.Columns)
            {
                switch (col.FieldName)
                {
                    case "_Id":
                    case "DataCadstro":
                    case "TipoPessoa":
                    case "Ativo":
                    case "PessoaFisica.Nome":
                    case "PessoaJuridica.RazaoSocial":
                        col.Visible = true;
                        break;
                    default:
                        col.Visible = false;
                        break;
                }
            }

            //btnWithdrawal.Visible = Properties.Settings.Default.AllowCashRequest;

            this.WindowState = FormWindowState.Maximized;
        }
    }
}
