using System;
using System.Windows.Forms;
using Models;

namespace ccb_ef6
{
    public partial class frmNovoOuEditaBordado : Form
    {
        private Bordado Bordado = null;
        private bool IsNewBordado;

        public frmNovoOuEditaBordado()
        {
            InitializeComponent();
        }

        public frmNovoOuEditaBordado(Bordado Bordado)
        {
            InitializeComponent();
            this.Bordado = Bordado;
            FillTextBoxSince(Bordado);
            txtArquivo.ReadOnly = true;
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(txtArquivo.Text))
            {
                errorProvider1.SetError(txtArquivo, "Digite um Nome");
                txtArquivo.Focus();
                return false;
            }
            errorProvider1.SetError(txtArquivo, "");

            if (BLL.BordadoServices.ArquivoExists(txtArquivo.Text, txtCaminho.Text) && IsNewBordado)
                {
                    errorProvider1.SetError(txtArquivo, "Este nome de Bordado já existe, digite um diferente");
                txtArquivo.Focus();
                    return false;
                }
                errorProvider1.SetError(txtArquivo, "");

            return true;
        }

        private void AssignDataFromTextBox(Bordado Bordado)
        {
            Bordado.Arquivo = txtArquivo.Text;
            Bordado.Caminho = txtCaminho.Text;
        }

        private void FillTextBoxSince(Bordado Bordado)
        {
            txtArquivo.Text = Bordado.Arquivo;
            txtCaminho.Text = Bordado.Caminho;
        }

        private void btnAddOrUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }

            //Registrar Bordado en la BD
            if (Bordado == null)
            {
                IsNewBordado = true;
                Bordado = new Bordado();

                AssignDataFromTextBox(Bordado);

                try
                {
                    //Creo al Bordado e inmediatamente creo su cuenta correspondiente
                    BLL.BordadoServices.AddNew(Bordado);

                    MessageBox.Show("Bordado cadastrado corretamente", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else//Actualizar Bordado en la BD
            {
                try
                {
                    IsNewBordado = false;
                    AssignDataFromTextBox(Bordado);
                    BLL.BordadoServices.Update(Bordado);
                    MessageBox.Show("Bordado actualizado satisfactoriamente", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
