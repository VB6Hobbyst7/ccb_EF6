using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Models;

namespace ccb_ef6
{
    public partial class frmNovoOuEditaFornecedor : Form
    {
        private Fornecedor Fornecedor = null;
        private bool IsNewFornecedor;

        public frmNovoOuEditaFornecedor()
        {
            InitializeComponent();
        }

        public frmNovoOuEditaFornecedor(Fornecedor Fornecedor)
        {
            InitializeComponent();
            this.Fornecedor = Fornecedor;
            FillTextBoxSince(Fornecedor);
            txtUsername.ReadOnly = true;
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                errorProvider1.SetError(txtNome, "Debe ingresar un nombre");
                txtNome.Focus();
                return false;
            }
            errorProvider1.SetError(txtNome, "");

            if (!string.IsNullOrEmpty(txtEmail.Text))
            {
                RegexUtilities regexUtilities = new RegexUtilities();

                if (!regexUtilities.IsValidEmail(txtEmail.Text))
                {
                    errorProvider1.SetError(txtEmail, "Ingrese un correo válido");
                    txtEmail.Focus();
                    return false;
                }

                errorProvider1.SetError(txtEmail, "");
            }

            if (BLL.FornecedorServices.NomeExists(txtNome.Text) && IsNewFornecedor)
            {
                errorProvider1.SetError(txtNome, "Este nome de fornecedor já existe, digite um diferente");
                txtNome.Focus();
                return false;
            }
            errorProvider1.SetError(txtNome, "");

            return true;
        }

        private void AssignDataFromTextBox(Fornecedor Fornecedor)
        {
            Fornecedor.Nome = txtNome.Text;
            Fornecedor.Contato_Funcao = txtContatoFuncao.Text;
            Fornecedor.Contato_Nome = txtContatoNome.Text;

            Fornecedor.Telefone1 = txtTelefone1.Text;
            Fornecedor.Telefone2 = txtTelefone2.Text;
            Fornecedor.Telefone3 = txtTelefone3.Text;
            Fornecedor.Email = txtEmail.Text;
            Fornecedor.Obs = txtObs.Text;
        }


        private void FillTextBoxSince(Fornecedor Fornecedor)
        {
            txtObs.Text = Fornecedor.Obs;
            txtTelefone1.Text = Fornecedor.Telefone1;
            txtTelefone2.Text = Fornecedor.Telefone2;
            txtTelefone3.Text = Fornecedor.Telefone3;
            txtEmail.Text = Fornecedor.Email;
            txtContatoFuncao.Text = Fornecedor.Contato_Funcao;
            txtContatoNome.Text = Fornecedor.Contato_Nome;
            txtNome.Text = Fornecedor.Nome;
            txtEstado.Text = Fornecedor.Estado;
            txtCidade.Text = Fornecedor.Cidade;
        }

        private void frmNewOrUpdateFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void btnAddOrUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }

            //Registrar Fornecedor en la BD
            if (Fornecedor == null)
            {
                IsNewFornecedor = true;
                Fornecedor = new Fornecedor();

                AssignDataFromTextBox(Fornecedor);

                try
                {
                    //Creo al Fornecedor e inmediatamente creo su cuenta correspondiente
                    BLL.FornecedorServices.AddNew(Fornecedor);

                    MessageBox.Show("Fornecedor agregado satisfactoriamente", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else//Actualizar Fornecedor en la BD
            {
                try
                {
                    IsNewFornecedor = false;
                    AssignDataFromTextBox(Fornecedor);
                    BLL.FornecedorServices.Update(Fornecedor);
                    MessageBox.Show("Fornecedor actualizado satisfactoriamente", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
