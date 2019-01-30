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

namespace Compra_y_Gana_v1._0
{
    public partial class frmNewOrUpdateCliente : Form
    {
        private Cliente cliente = null;
        private bool IsNewCliente;

        public frmNewOrUpdateCliente()
        {
            InitializeComponent();
        }

        public frmNewOrUpdateCliente(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
            FillTextBoxSince(cliente);
            txtUsername.ReadOnly = true;
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

        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                errorProvider1.SetError(txtNome, "Debe ingresar un nombre");
                txtNome.Focus();
                return false;
            }
            errorProvider1.SetError(txtNome, "");

            if (string.IsNullOrEmpty(txtContatoFuncao.Text))
            {
                errorProvider1.SetError(txtContatoFuncao, "Debe ingresar el apellido paterno");
                txtContatoFuncao.Focus();
                return false;
            }
            errorProvider1.SetError(txtContatoFuncao, "");

            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                errorProvider1.SetError(txtUsername, "Debe ingresar un nombre de usuario");
                txtUsername.Focus();
                return false;
            }
            errorProvider1.SetError(txtUsername, "");

            if (txtUsername.Text.Length < 5)
            {
                errorProvider1.SetError(txtUsername, "El nombre de usuario debe tener al menos 5 caracteres");
                txtUsername.Focus();
                return false;
            }

            if (BLL.CustomerServices.UsernameExists(txtUsername.Text) && IsNewCliente)
            {
                errorProvider1.SetError(txtUsername, "El nombre de usuario ya existe, elija uno diferente");
                txtUsername.Focus();
                return false;
            }
            errorProvider1.SetError(txtUsername, "");

            if (string.IsNullOrEmpty(txtCidade.Text))
            {
                errorProvider1.SetError(txtCidade, "Debe ingresar una contraseña");
                txtCidade.Focus();
                return false;
            }
            errorProvider1.SetError(txtCidade, "");

            if (txtCidade.Text.Length < 4)
            {
                errorProvider1.SetError(txtCidade, "La contraseña debe tener al menos 4 caracteres");
                txtCidade.Focus();
                return false;
            }
            errorProvider1.SetError(txtCidade, "");

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

            return true;
        }

        private void AssignDataFromTextBox(Cliente cliente)
        {
            cliente.Nome = txtNome.Text;
            cliente.Contato_Funcao = txtContatoFuncao.Text;
            cliente.Contato_Nome = txtContatoNome.Text;

            cliente.Telefone1 = txtTelefone1.Text;
            cliente.Telefone2 = txtTelefone2.Text;
            cliente.Telefone3 = txtTelefone3.Text;
            cliente.Email = txtEmail.Text;
            cliente.Obs = txtObs.Text;
        }


        private void FillTextBoxSince(Cliente cliente)
        {
            txtObs.Text = cliente.Obs;
            txtTelefone1.Text = cliente.Telefone1;
            txtTelefone2.Text = cliente.Telefone2;
            txtTelefone3.Text = cliente.Telefone3;
            txtEmail.Text = cliente.Email;
            txtContatoFuncao.Text = cliente.Contato_Funcao;
            txtContatoNome.Text = cliente.Contato_Nome;
            txtNome.Text = cliente.Nome;
            txtEstado.Text = cliente.Estado;
            txtCidade.Text = cliente.Cidade;
        }

        private void frmNewOrUpdateCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
