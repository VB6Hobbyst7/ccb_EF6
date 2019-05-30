using System;
using System.Windows.Forms;
using Models;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace ccb_ef6
{
    public partial class frmNovoOuEditaBordado : Form
    {
        private Bordado bordado = null;
        private bool IsNewBordado;

        DataTable dt = new DataTable();


        public frmNovoOuEditaBordado()
        {
            InitializeComponent();
        }

        public frmNovoOuEditaBordado(Bordado bordado)
        {
            InitializeComponent();
            this.bordado = bordado;
            FillTextBoxSince(bordado);
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

        private void AssignDataFromTextBox(Bordado bordado)
        {
            bordado.Arquivo = txtArquivo.Text;
            bordado.Caminho = txtCaminho.Text;
            bordado.Descricao = txtDescricao.Text;

        }

        private void FillTextBoxSince(Bordado bordado)
        {
           
            try
            {
                txtArquivo.Text = bordado.Arquivo;
                txtCaminho.Text = bordado.Caminho;

                if (bordado.BordadoLinhas.Count < 1)
                    return;

                if (dt.Columns.Count < 1)
                {
                    dt.Columns.Add("seq");
                    dt.Columns.Add("codigo");
                    dt.Columns.Add("cor");
                    dt.Columns.Add("nome");

                }
                foreach (BordadoLinha l in bordado.BordadoLinhas)
                {
                    dt.Rows.Add(l.seq, l.LinhaCodigo, 0, "teste");
                }
            }
            catch (Exception)
            {

                //throw;
            }

            dgLinhas_Utilizadas.DataSource = dt;

            //dgLinhas_Utilizadas.DataSource = Bordado.Linhas;
        }

        private void btnAddOrUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }

            //Inserir Bordado no BD
            if (bordado == null)
            {
                IsNewBordado = true;
                bordado = new Bordado();

                AssignDataFromTextBox(bordado);

                try
                {
                    //Creo al Bordado e inmediatamente creo su cuenta correspondiente
                    BLL.BordadoServices.AddNew(bordado);

                    MessageBox.Show("Bordado cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else//Atualizar Bordado no BD
            {
                try
                {
                    IsNewBordado = false;
                    AssignDataFromTextBox(bordado);
                    BLL.BordadoServices.Update(bordado);
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
