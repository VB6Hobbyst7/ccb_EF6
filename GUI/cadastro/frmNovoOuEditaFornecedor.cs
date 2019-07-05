using System;
using System.Windows.Forms;
using Models;
using BLL;

namespace ccb_ef6
{
    public partial class frmNovoOuEditaFornecedor : Form
    {
        protected Service_ccb _service;
        private ClienteViewModel cliente = null;

        private Pessoa pessoa = null;
        private bool IsNewPessoa;

        public frmNovoOuEditaFornecedor()
        {
            InitializeComponent();
        }

        public frmNovoOuEditaFornecedor(Pessoa pessoa)
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

        private void AssignDataFromTextBox(Pessoa pessoa)
        {

            //pessoa.DataCadastro = DateTime.Now;

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

            if (pessoa != null)
                endereco.EnderecoId = pessoa.Id;
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
                //pessoaFisica.Endereco.Add(endereco);

                // Adicionando PF em Pessoa
                if (pessoa != null)
                    pessoaFisica.Id = pessoa.Id;

                pessoa.PessoaFisica = pessoaFisica;
                pessoa.TipoPessoa =  TipoPessoa.Fisica;
            }
            else
            {
                // PJ de Pessoa
                var pessoaJuridica = new PessoaJuridica()
                {
                    RazaoSocial = txtNomeRazaoSocial.Text,
                    CNPJ = txtCpfCnpj.Text,
                    Pessoa = pessoa
                };
                // Adicionando EnderecoPF em PF
                //pessoaJuridica.Endereco.Add(endereco);

                // Adicionando PJ em Pessoa
                if (pessoa != null)
                    pessoaJuridica.Id = pessoa.Id;
                pessoa.PessoaJuridica = pessoaJuridica;
                pessoa.TipoPessoa = TipoPessoa.Juridica;
            }

            //pessoa.DataCadastro = DateTime.Now;
            pessoa.Ativo = chkAtivo.Checked;
            pessoa.Endereco = endereco;
        }

        private void FillTextBoxSince(Pessoa pessoa)
        {
            chkAtivo.Checked = pessoa.Ativo;
            txtLogradoro.Text = pessoa.Endereco.Logradouro;
            txtNumero.Text = pessoa.Endereco.Numero;
            txtComplemento.Text = pessoa.Endereco.Complemento;
            txtBairro.Text = pessoa.Endereco.Bairro;
            txtCEP.Text = pessoa.Endereco.Cep;
            txtCidade.Text = pessoa.Endereco.Cidade;
            txtUf.Text = pessoa.Endereco.Estado;

            if (pessoa.TipoPessoa  ==  TipoPessoa.Fisica)
            {
                rgPfPj.SelectedIndex = 0;
                txtCpfCnpj.Text = pessoa.PessoaFisica.CPF;
                txtNomeRazaoSocial.Text = pessoa.PessoaFisica.Nome;
            }
            else
            {
                rgPfPj.SelectedIndex = 1;
                txtCpfCnpj.Text = pessoa.PessoaJuridica.CNPJ;
                txtNomeRazaoSocial.Text = pessoa.PessoaJuridica.RazaoSocial;
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
                chkAtivo.Checked = true;
                //pessoa = new Pessoa();
                Pessoa pessoa = new Pessoa();

               AssignDataFromTextBox(pessoa);
                pessoa.DataCadastro = DateTime.Now;

                try
                {
                    //Creo al cliente e inmediatamente creo su cuenta correspondiente
                    //_service.Adicionar(cliente);
                    BLL.PessoaServices.AddNew(pessoa);

                    MessageBox.Show("Cliente gravado com sucesso.", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    //Pessoa pessoa = new Pessoa();
                    AssignDataFromTextBox(this.pessoa);

                    //_service.AtualizarPessoa(cliente);
                    BLL.PessoaServices.Update(pessoa);
                    //Repository.RepositoryBase
                    MessageBox.Show("Cliente gravado com sucesso.", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            PfOuPj(0);
        }

        private void frmNovoOuEditaFornecedor_Load(object sender, EventArgs e)
        {
            _service = new Service_ccb();

            //LimpaTela();
        }
    }
}
