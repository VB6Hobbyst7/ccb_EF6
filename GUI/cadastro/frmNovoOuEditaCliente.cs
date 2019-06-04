using System;
using System.Windows.Forms;
using Models;

namespace ccb_ef6
{
    public partial class frmNovoOuEditaCliente : Form
    {
        private Cliente cliente = null;
        private bool IsNewCliente;

        public frmNovoOuEditaCliente()
        {
            InitializeComponent();
        }

        public frmNovoOuEditaCliente(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
            FillTextBoxSince(cliente);
            txtNome.ReadOnly = true;
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                errorProvider1.SetError(txtNome, "Digite um Nome");
                txtNome.Focus();
                return false;
            }
            errorProvider1.SetError(txtNome, "");

            if (!string.IsNullOrEmpty(txtComplemento.Text))
            {
                RegexUtilities regexUtilities = new RegexUtilities();

                if (!regexUtilities.IsValidEmail(txtComplemento.Text))
                {
                    errorProvider1.SetError(txtComplemento, "Digite um eMail válido");
                    txtComplemento.Focus();
                    return false;
                }

                errorProvider1.SetError(txtComplemento, "");

                if (BLL.ClienteServices.NomeExists(txtNome.Text) && IsNewCliente)
                {
                    errorProvider1.SetError(txtNome, "Este nome de cliente já existe, digite um diferente");
                    txtNome.Focus();
                    return false;
                }
                errorProvider1.SetError(txtNome, "");

            }

            return true;
        }

        private void AssignDataFromTextBox(Cliente cliente)
        {
            cliente.Nome = txtNome.Text;
            cliente.Contato_Funcao = txtContatoFuncao.Text;
            cliente.Contato_Nome = txtContatoNome.Text;

            cliente.Email = txtComplemento.Text;
        }


        private void FillTextBoxSince(Cliente cliente)
        {
            txtComplemento.Text = cliente.Email;
            txtContatoFuncao.Text = cliente.Contato_Funcao;
            txtContatoNome.Text = cliente.Contato_Nome;
            txtNome.Text = cliente.Nome;
            txtEstado.Text = cliente.Estado;
            txtCidade.Text = cliente.Cidade;
        }

        private void btnAddOrUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }

            //Registrar cliente en la BD
            if (cliente == null)
            {
                IsNewCliente = true;
                cliente = new Cliente();

                AssignDataFromTextBox(cliente);

                try
                {
                    //Creo al cliente e inmediatamente creo su cuenta correspondiente
                    BLL.ClienteServices.AddNew(cliente);

                    MessageBox.Show("Cliente agregado satisfactoriamente", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else//Actualizar cliente en la BD
            {
                try
                {
                    IsNewCliente = false;
                    AssignDataFromTextBox(cliente);
                    BLL.ClienteServices.Update(cliente);
                    MessageBox.Show("Cliente actualizado satisfactoriamente", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
