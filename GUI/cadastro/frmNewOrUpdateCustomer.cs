using System;

using System.Windows.Forms;
using DAL;
using Models;

namespace ccb_ef6
{
    public partial class frmNewOrUpdateCustomer : Form
    {
        private Customer customer = null;
        private bool IsNewCustomer;

        public frmNewOrUpdateCustomer()
        {
            InitializeComponent();
        }

        public frmNewOrUpdateCustomer(Customer customer)
        {
            InitializeComponent();
            this.customer = customer;
            FillTextBoxSince(customer);
            txtUsername.ReadOnly = true;
        }        

        private void frmNewOrUpdateCustomer_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAddOrUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }

            //Registrar cliente en la BD
            if (customer == null)
            {
                IsNewCustomer = true;
                customer = new Customer();
                
                AssignDataFromTextBox(customer);

                try
                {
                    //Creo al cliente e inmediatamente creo su cuenta correspondiente
                    BLL.CustomerServices.AddNew(customer);

                    if (customer.CustomerID !=0)
                    {
                        BLL.AccountServices.NewAccount(new Account { CustomerID = customer.CustomerID, Active = true, CurrentPointsBalance = 0, CreatedDate = customer.CreatedDate });
                    }

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
                    IsNewCustomer = false;
                    AssignDataFromTextBox(customer);
                    BLL.CustomerServices.Update(customer);
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
            if (string.IsNullOrEmpty(txtName.Text))
            {
                errorProvider1.SetError(txtName, "Debe ingresar un nombre");
                txtName.Focus();
                return false;
            }
            errorProvider1.SetError(txtName, "");

            if (string.IsNullOrEmpty(txtPaternalLastname.Text))
            {
                errorProvider1.SetError(txtPaternalLastname, "Debe ingresar el apellido paterno");
                txtPaternalLastname.Focus();
                return false;
            }
            errorProvider1.SetError(txtPaternalLastname, "");

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

            if (BLL.CustomerServices.UsernameExists(txtUsername.Text) && IsNewCustomer)
            {
                errorProvider1.SetError(txtUsername, "El nombre de usuario ya existe, elija uno diferente");
                txtUsername.Focus();
                return false;
            }
            errorProvider1.SetError(txtUsername, "");

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                errorProvider1.SetError(txtPassword, "Debe ingresar una contraseña");
                txtPassword.Focus();
                return false;
            }
            errorProvider1.SetError(txtPassword, "");

            if (txtPassword.Text.Length < 4)
            {
                errorProvider1.SetError(txtPassword, "La contraseña debe tener al menos 4 caracteres");
                txtPassword.Focus();
                return false;
            }
            errorProvider1.SetError(txtPassword, "");

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

        private void AssignDataFromTextBox(Customer customer)
        {
            customer.Address = txtAddress.Text;
            customer.Cellphone = txtCellphone.Text;
            customer.Email = txtEmail.Text;
            customer.MaternalLastname = txtMaternalLastname.Text;
            customer.Names = txtName.Text;
            customer.Nickname = txtNickname.Text;
            customer.Password = txtPassword.Text;
            customer.PaternalLastname = txtPaternalLastname.Text;
            customer.Phone = txtPhone.Text;
            customer.Username = txtUsername.Text;
        }

        private void FillTextBoxSince(Customer customer)
        {
            txtAddress.Text = customer.Address;
            txtCellphone.Text = customer.Cellphone;
            txtEmail.Text = customer.Email;
            txtMaternalLastname.Text = customer.MaternalLastname;
            txtName.Text = customer.Names;
            txtNickname.Text = customer.Nickname;
            txtPassword.Text = customer.Password;
            txtPaternalLastname.Text = customer.PaternalLastname;
            txtPhone.Text = customer.Phone;
            txtUsername.Text = customer.Username;
        }

        private void btnPessoa_Click(object sender, EventArgs e)
        {
            var rnd = new Random();

            // Pessoa
            var pessoa = new Pessoa()
            {
                DataCadastro = DateTime.Now,
                Ativo = true,
                NegarCredito = false
            };

            // Endereco PF de Pessoa
            var enderecoPF = new Endereco()
            {
                Logradouro = "Rua dos Moradores ",
                Bairro = "Centro",
                Cep = "321000" + rnd.Next(1, 13),
                Estado = "São Paulo",
                Cidade = "São Paulo",
                Numero = rnd.Next(1, 13).ToString(),
                Complemento = "Fundos"
            };

            // PF de Pessoa
            var pessoaFisica = new PessoaFisica()
            {
                Nome = "Nome " + rnd.Next(1, 13),
                Cpf = "321456987" + rnd.Next(1, 13),
                Pessoa = pessoa
            };

            // Endereco PJ 1 de Pessoa
            var enderecoPJ1 = new Endereco()
            {
                Logradouro = "Av. Paulista ",
                Bairro = "Bela Vista",
                Cep = "123000" + rnd.Next(1, 13),
                Estado = "São Paulo",
                Cidade = "São Paulo",
                Numero = rnd.Next(1, 13).ToString(),
                Complemento = "Frente"
            };

            // Endereco PJ 2 de Pessoa
            var enderecoPJ2 = new Endereco()
            {
                Logradouro = "Av. Paulista ",
                Bairro = "Bela Vista",
                Cep = "123000" + rnd.Next(1, 13),
                Estado = "São Paulo",
                Cidade = "São Paulo",
                Numero = rnd.Next(1, 13).ToString(),
                Complemento = "Frente"
            };

            // PJ 1 de Pessoa
            var pessoaJuridica1 = new PessoaJuridica()
            {
                RazaoSocial = "Empresa " + rnd.Next(1, 13),
                Cnpj = "986543210001" + rnd.Next(1, 13),
                Pessoa = pessoa
            };

            // PJ 2 de Pessoa
            var pessoaJuridica2 = new PessoaJuridica()
            {
                RazaoSocial = "Empresa " + rnd.Next(1, 13),
                Cnpj = "986543210001" + rnd.Next(1, 13),
                Pessoa = pessoa
            };

            // Instancia do Contexto do EF
            var contexto = new LoyaltyDB();

            //#### INICIO SETUP de PF, PJ e Endereços ####

            // Adicionando EnderecoPF em PF
            pessoaFisica.EnderecoList.Add(enderecoPF);

            // Adicionando PF em Pessoa
            pessoa.PessoaFisica = pessoaFisica;

            // Adicionando EnderecoPJ1 em PJ1
            pessoaJuridica1.EnderecoList.Add(enderecoPJ1);

            // Adicionando EnderecoPJ2 em PJ2
            pessoaJuridica2.EnderecoList.Add(enderecoPJ2);

            // Adicionando PJ 1 em Pessoa
            pessoa.PessoaJuridicaList.Add(pessoaJuridica1);

            // Adicionando PJ 2 em Pessoa
            pessoa.PessoaJuridicaList.Add(pessoaJuridica2);

            //#### FIM SETUP de PF, PJ e Endereços ####

            // Adicionando Pessoa no Contexto
            contexto.Pessoa.Add(pessoa);

            // Salvando todas as inclusões
            contexto.SaveChanges();
        }
    }
}
