using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public static class PessoaServices
    {
        public static void AddNewPessoa(string Nome, string Contato_Funcao, string Contato_Nome, string Cgc_Cpf, string Inscr_Estadual,
            string Endereco, string Cidade, string Estado, string Cep, string Telefone1, string Telefone2, string Telefone3,
            string Email, string Obs, decimal Preco_Base)
        {
            using (LoyaltyDB db = new LoyaltyDB())
            {
                db.Pessoa.Add(new Pessoa
                {
                    DataCadastro = DateTime.Now,
                    Ativo = true,
                    NegarCredito = false
                });
            }
        }

        public static List<Pessoa> GetAll()
        {
            List<Pessoa> list = new List<Pessoa>();

            using (LoyaltyDB db = new LoyaltyDB())
            {
                list = db.Pessoa.ToList();
            }

            return list;
        }

        public static void AddNew(Pessoa Pessoa)
        {
            using (LoyaltyDB db = new LoyaltyDB())
            {
                db.Pessoa.Add(Pessoa);
                db.SaveChanges();
            }
        }

        public static void Update(Pessoa Pessoa)
        {
            using (LoyaltyDB db = new LoyaltyDB())
            {
                db.Entry(Pessoa).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public static bool NomeExists(string nome)
        {
            using (LoyaltyDB db = new LoyaltyDB())
            {
                Pessoa Pessoa = db.Pessoa.Where(u => u.Ativo).SingleOrDefault();

                if (Pessoa != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static Pessoa FindById(int id)
        {
            Pessoa Pessoa = null;

            using (LoyaltyDB db = new LoyaltyDB())
            {
                Pessoa = db.Pessoa.Find(id);

                if (Pessoa != null)
                {
                    return Pessoa;
                }
            }

            return null;
        }

        public static List<Pessoa> FindByPessoaData(string text)
        {
            using (LoyaltyDB db = new LoyaltyDB())
            {
                return db.Pessoa.Where(x => x.PessoaFisica.Nome.Contains(text)).ToList();
            }
        }
    }
}