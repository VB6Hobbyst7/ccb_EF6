using System;
using System.Windows.Forms;
using Models;

namespace ccb_ef6
{
    public partial class frmNovoOuEditaCliente : Form
    {
        private Pessoa pessoa = null;
        private bool IsNewPessoa;

        public frmNovoOuEditaCliente()
        {
            InitializeComponent();
        }

        public frmNovoOuEditaCliente(Pessoa pessoa)
        {
            InitializeComponent();
            this.pessoa = pessoa;
            FillTextBoxSince(pessoa);
            txtNomeRazaoSocial.ReadOnly = true;
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrEmpty(txtNomeRazaoSocial.Text))
            {
                errorProvider1.SetError(txtNomeRazaoSocial, "Digite um Nome");
                txtNomeRazaoSocial.Focus();
                return false;
            }
            errorProvider1.SetError(txtNomeRazaoSocial, "");

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

                if (BLL.ClienteServices.NomeExists(txtNomeRazaoSocial.Text) && IsNewPessoa)
                {
                    errorProvider1.SetError(txtNomeRazaoSocial, "Este nome de cliente já existe, digite um diferente");
                    txtNomeRazaoSocial.Focus();
                    return false;
                }
                errorProvider1.SetError(txtNomeRazaoSocial, "");
            }
            return true;
        }

        private void AssignDataFromTextBox(Pessoa pessoa)
        {
            pessoa.DataCadastro = DateTime.Now;
            pessoa.Ativo = chkAtivo.Checked;
            pessoa.NegarCredito = chkCreditoNegado.Checked;

            // Endereco de Pessoa
            var endereco = new Endereco()
            {
                Logradouro = txtLogradoro.Text,
                Bairro = txtBairro.Text,
                Cep = txtCEP.Text,
                Estado = txtUf.Text,
                Cidade = txtCidade.Text,
                Numero = txtNumero.Text,
                Complemento = txtComplemento.Text
            };

            if (rgPfPj.SelectedIndex == 0)  //PF
            {
                // PF de Pessoa
                var pessoaFisica = new PessoaFisica()
                {
                    Nome = txtNomeRazaoSocial.Text,
                    Cpf = txtCpfCnpj.Text,
                    Pessoa = pessoa
                };
                // Adicionando EnderecoPF em PF
                pessoaFisica.EnderecoList.Add(endereco);

                // Adicionando PF em Pessoa
                pessoa.PessoaFisica = pessoaFisica;
            }
            else
            {
                // PJ 1 de Pessoa
                var pessoaJuridica1 = new PessoaJuridica()
                {
                    RazaoSocial = txtNomeRazaoSocial.Text,
                    Cnpj = txtCpfCnpj.Text,
                    Pessoa = pessoa
                };

                // Adicionando EnderecoPJ1 em PJ1
                pessoaJuridica1.EnderecoList.Add(endereco);

                // Adicionando PJ 1 em Pessoa
                pessoa.PessoaJuridicaList.Add(pessoaJuridica1);
            }
        }


        private void FillTextBoxSince(Pessoa pessoa)
        {

            txtCpfCnpj.Text = pessoa.PessoaFisica.Cpf;
            
        }

        private void btnAddOrUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }

            //Registrar cliente en la BD
            if (pessoa == null)
            {
                IsNewPessoa = true;
                pessoa = new Pessoa();

                AssignDataFromTextBox(pessoa);

                try
                {
                    //Creo al cliente e inmediatamente creo su cuenta correspondiente
                    BLL.PessoaServices.AddNew(pessoa);

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
                    IsNewPessoa = false;
                    AssignDataFromTextBox(pessoa);
                    BLL.PessoaServices.Update(pessoa);
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

        private void rgPfPj_SelectedIndexChanged(object sender, EventArgs e)
        {
            PfOuPj(rgPfPj.SelectedIndex);
        }

        private void PfOuPj( int pj)
        {
            if (pj == 1)
            {
                lblCpfCnpj.Text = "CNPJ:";
                lblNomeRazaoSocial.Text = "Razão Social:";
            }
            else
            {
                lblCpfCnpj.Text = "CPF:";
                lblNomeRazaoSocial.Text = "Nome:";
            }
        }

        private void LimpaTela()
        {
            txtCpfCnpj.Text = "";
            txtNomeRazaoSocial.Text = "";
            txtLogradoro.Text = "";
            txtNumero.Text = "";
            txtComplemento.Text = "";
            txtCidade.Text = "";
            txtUf.Text = "";
            chkAtivo.Checked = true;
            chkCreditoNegado.Checked = false;

            PfOuPj(0);
        }

        private void frmNovoOuEditaCliente_Load(object sender, EventArgs e)
        {
            LimpaTela();
        }
    }
}
