using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class FornecedorServices
    {
        public static void AddNewFornecedor(string Nome, string Contato_Funcao, string Contato_Nome, string Cgc_Cpf, string Inscr_Estadual,
            string Endereco, string Cidade, string Estado, string Cep, string Telefone1, string Telefone2, string Telefone3,
            string Email, string Obs, decimal Preco_Base)
        {
            using (LoyaltyDB db = new LoyaltyDB())
            {
                db.Fornecedores.Add(new Fornecedor
                {
                    Nome = Nome,
                    Contato_Funcao = Contato_Funcao,
                    Cgc_Cpf = Cgc_Cpf,
                    Inscr_Estadual = Inscr_Estadual,
                    Endereco = Endereco,
                    Cidade = Cidade,
                    Estado = Estado,
                    Cep = Cep,
                    Telefone1 = Telefone1,
                    Telefone2 = Telefone2,
                    Telefone3 = Telefone3,
                    Email = Email,
                    Obs = Obs
                });
            }
        }

        public static List<Fornecedor> GetAll()
        {
            List<Fornecedor> list = new List<Fornecedor>();

            using (LoyaltyDB db = new LoyaltyDB())
            {
                list = db.Fornecedores.ToList();
            }

            return list;
        }

        public static void AddNew(Fornecedor Fornecedor)
        {
            using (LoyaltyDB db = new LoyaltyDB())
            {
                db.Fornecedores.Add(Fornecedor);
                db.SaveChanges();
            }
        }

        public static void Update(Fornecedor Fornecedor)
        {
            using (LoyaltyDB db = new LoyaltyDB())
            {
                Fornecedor.ModifiedDate = DateTime.Now;
                db.Entry(Fornecedor).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }


        public static bool NomeExists(string nome)
        {
            using (LoyaltyDB db = new LoyaltyDB())
            {
                Fornecedor fornecedor = db.Fornecedores.Where(u => u.Nome == nome).SingleOrDefault();

                if (fornecedor != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static Fornecedor FindById(int id)
        {
            Fornecedor Fornecedor = null;

            using (LoyaltyDB db = new LoyaltyDB())
            {
                Fornecedor = db.Fornecedores.Find(id);

                if (Fornecedor != null)
                {
                    return Fornecedor;
                }
            }

            return null;
        }

        public static List<Fornecedor> FindByFornecedorData(string text)
        {
            using (LoyaltyDB db = new LoyaltyDB())
            {
                return db.Fornecedores.Where(x => x.Nome.Contains(text) || x.Contato_Nome.Contains(text)
                || x.Telefone1.Contains(text) || x.Telefone2.Contains(text) || x.Email.Contains(text)).ToList();
            }
        }
    }
}
