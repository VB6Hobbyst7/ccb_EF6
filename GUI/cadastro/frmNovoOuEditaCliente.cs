using System;
using System.Windows.Forms;
using Models;
using BLL;
using Models.ViewModel;

namespace ccb_ef6
{
    public partial class frmNovoOuEditaCliente : Form
    {
        protected Service_ccb _service;
        private ClienteViewModel cliente = null;

        private PessoaViewModel pessoa = null;
        private bool IsNewPessoa;

        public frmNovoOuEditaCliente()
        {
            InitializeComponent();
            _service = new Service_ccb();
        }

        public frmNovoOuEditaCliente(PessoaViewModel pessoa)
        {
            InitializeComponent();
            this.pessoa = pessoa;
            //this.pessoa = pessoa;
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
                //RegexUtilities regexUtilities = new RegexUtilities();

                //if (!regexUtilities.IsValidEmail(txtComplemento.Text))
                //{
                //    errorProvider1.SetError(txtComplemento, "Digite um eMail válido");
                //    txtComplemento.Focus();
                //    return false;
               // }

                //errorProvider1.SetError(txtComplemento, "");

                //if (BLL.ClienteServices.NomeExists(txtNomeRazaoSocial.Text) && IsNewPessoa)
                //{
                //    errorProvider1.SetError(txtNomeRazaoSocial, "Este nome de cliente já existe, digite um diferente");
                //    txtNomeRazaoSocial.Focus();
                //    return false;
                //}
                //errorProvider1.SetError(txtNomeRazaoSocial, "");
            }
            return true;
        }

        private void AssignDataFromTextBox(PessoaViewModel pessoa)
        {

            pessoa.DataCadastro = DateTime.Now;

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
                    CPF = txtCpfCnpj.Text,
                    Pessoa = pessoa
                };
                // Adicionando EnderecoPF em PF
                pessoaFisica.Endereco.Add(endereco);

                // Adicionando PF em Pessoa
                pessoa.PessoaFisica = pessoaFisica;
                pessoa.TipoPessoa = TipoPessoa.PessoaFisica;
            }
            else
            {
                // PJ 1 de Pessoa
                var pessoaJuridica = new PessoaJuridica()
                {
                    RazaoSocial = txtNomeRazaoSocial.Text,
                    CNPJ = txtCpfCnpj.Text,
                    Pessoa = pessoa
                };

                // Adicionando EnderecoPF em PF
                pessoaJuridica.Endereco.Add(endereco);

                // Adicionando PF em Pessoa
                pessoa.PessoaJuridica = pessoaJuridica;
                pessoa.TipoPessoa = TipoPessoa.PessoaJuridica;
            }
        }

        private void FillTextBoxSince(PessoaViewModel pessoa)
        {
            if (pessoa.TipoPessoa  ==  TipoPessoaViewModel.PessoaFisica)
            {
                rgPfPj.SelectedIndex = 0;
                txtCpfCnpj.Text = pessoa.PessoaFisica.CPF;
                txtNomeRazaoSocial.Text = pessoa.PessoaFisica.Nome;
                //txtLogradoro.Text = pessoa.PessoaFisica.Endereco->Logradouro;
                //txtNumero.Text = pessoa.PessoaFisica.Endereco[0].Numero;
                //txtComplemento.Text = pessoa.PessoaFisica.Endereco[0].Complemento;
                //txtCidade.Text = pessoa.PessoaFisica.Endereco[0].Cidade;
                //txtCEP.Text = pessoa.PessoaFisica.Endereco[0].Cep;
            }
            else
            {
                rgPfPj.SelectedIndex = 1;
                txtCpfCnpj.Text = pessoa.PessoaJuridica.CNPJ;
                txtNomeRazaoSocial.Text = pessoa.PessoaJuridica.RazaoSocial;
                //txtLogradoro.Text = pessoa.PessoaJuridica.Endereco[0].Logradouro;
                //txtNumero.Text = pessoa.PessoaJuridica.Endereco[0].Numero;
                //txtComplemento.Text = pessoa.PessoaFisica.Endereco[0].Complemento;
                //txtCidade.Text = pessoa.PessoaJuridica.Endereco[0].Cidade;
                //txtCEP.Text = pessoa.PessoaJuridica.Endereco[0].Cep;
            }
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
                //pessoa = new Pessoa();
                PessoaViewModel pessoa = new PessoaViewModel();

                AssignDataFromTextBox(pessoa);

                try
                {
                    //Creo al cliente e inmediatamente creo su cuenta correspondiente
                    _service.Adicionar(cliente);
                    //BLL.PessoaServices.AddNew(pessoa);

                    MessageBox.Show("Cliente agregado satisfactoriamente", "Mensaje del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    cliente = null;
                    MessageBox.Show(ex.Message);
                }
            }
            else//Atualizar
            {
                try
                {
                    IsNewPessoa = false;
                    AssignDataFromTextBox(pessoa);
                    //BLL.PessoaServices.Update(pessoa);
                    //Repository.RepositoryBase
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
            //LimpaTela();
        }
    }
}
