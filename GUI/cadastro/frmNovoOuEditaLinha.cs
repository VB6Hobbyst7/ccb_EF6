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
    public partial class frmNovoOuEditaLinha : Form
    {
        private Linha Linha = null;
        private bool IsNewLinha;

        public frmNovoOuEditaLinha()
        {
            InitializeComponent();
        }

        public frmNovoOuEditaLinha(Linha Linha)
        {
            InitializeComponent();
            this.Linha = Linha;
            FillTextBoxSince(Linha);
            txtMaterial.ReadOnly = true;
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                errorProvider1.SetError(txtNome, "Deve digitar um Nome");
                txtNome.Focus();
                return false;
            }
            errorProvider1.SetError(txtNome, "");

            return true;
        }

        private void AssignDataFromTextBox(Linha Linha)
        {
            Linha.Codigo = txtCodigo.Text;
            Linha.Nome = txtNome.Text;
            Linha.Cor = ceCor.Color.ToArgb();
            Linha.MaterialFabricante = txtFabricante.Text;
            Linha.MaterialNome = txtMaterial.Text;
            Linha.MaterialTipo = txtTipo.Text;
            Linha.Estoque_1 = Convert.ToInt32(txtEstoque1.Text);
            Linha.Estoque_2 = Convert.ToInt32(txtEstoque2.Text);
            Linha.Minimo = Convert.ToInt32(txtMinimo.Text);
        }

        private void FillTextBoxSince(Linha Linha)
        {

            txtCodigo.Text = Linha.Codigo;
            txtNome.Text = Linha.Nome;
            ceCor.EditValue = Linha.Cor;

            txtFabricante.Text = Linha.MaterialFabricante;
            txtMaterial.Text = Linha.MaterialNome;
            txtTipo.Text = Linha.MaterialTipo;

            txtEstoque1.Text = Convert.ToString( Linha.Estoque_1);
            txtEstoque2.Text = Convert.ToString(Linha.Estoque_2);
            txtMinimo.Text = Convert.ToString(Linha.Minimo);
        }

        private void btnAddOrUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }

            //Registrar Linha en la BD
            if (Linha == null)
            {
                IsNewLinha = true;
                Linha = new Linha();

                AssignDataFromTextBox(Linha);

                try
                {
                    //Creo al Linha e inmediatamente creo su cuenta correspondiente
                    BLL.LinhaServices.AddNew(Linha);

                    MessageBox.Show("Linha agregado satisfactoriamente", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else//Actualizar Linha en la BD
            {
                try
                {
                    IsNewLinha = false;
                    AssignDataFromTextBox(Linha);
                    BLL.LinhaServices.Update(Linha);
                    MessageBox.Show("Linha actualizado satisfactoriamente", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void frmNovoOuEditaLinha_Load(object sender, EventArgs e)
        {

        }
    }
}
