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

            if (!string.IsNullOrEmpty(txtEmail.Text))
            {
                RegexUtilities regexUtilities = new RegexUtilities();

                if (!regexUtilities.IsValidEmail(txtEmail.Text))
                {
                    errorProvider1.SetError(txtEmail, "Digite um eMail válido");
                    txtEmail.Focus();
                    return false;
                }

                errorProvider1.SetError(txtEmail, "");

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
