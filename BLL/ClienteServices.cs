using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL
{
    public static class ClienteServices
    {
        public static void AddNewCliente(string Nome, string Contato_Funcao, string Contato_Nome, string Cgc_Cpf, string Inscr_Estadual,
            string Endereco, string Cidade, string Estado, string Cep, string Telefone1, string Telefone2, string Telefone3,
            string Email, string Obs, decimal Preco_Base)
        {
            using (LoyaltyDB db = new LoyaltyDB())
            {
                db.Clientes.Add(new Cliente
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
                    Obs = Obs,
                    Preco_Base = Preco_Base
                });
            }
        }

        public static List<Pessoa> GetAll()
        {
            List<Pessoa> list = new List<Pessoa>();

            using (LoyaltyDB db = new LoyaltyDB())
            {
                list = db.Pessoas.ToList();
            }

            return list;
        }

        public static void AddNew(Cliente cliente)
        {
            using (LoyaltyDB db = new LoyaltyDB())
            {
                db.Clientes.Add(cliente);
                db.SaveChanges();
            }
        }

        public static void Update(Cliente cliente)
        {
            using (LoyaltyDB db = new LoyaltyDB())
            {
                cliente.ModifiedDate = DateTime.Now;
                db.Entry(cliente).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public static bool NomeExists(string nome)
        {
            using (LoyaltyDB db = new LoyaltyDB())
            {
                Cliente cliente = db.Clientes.Where(u => u.Nome == nome).SingleOrDefault();

                if (cliente != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static Cliente FindById(Guid id)
        {
            Cliente cliente = null;

            using (LoyaltyDB db = new LoyaltyDB())
            {
                cliente = db.Clientes.Find(id);

                if (cliente != null)
                {
                    return cliente;
                }
            }

            return null;
        }

        public static List<Cliente> FindByClienteData(string text)
        {
            using (LoyaltyDB db = new LoyaltyDB())
            {
                return db.Clientes.Where(x => x.Nome.Contains(text) || x.Contato_Nome.Contains(text)
                || x.Telefone1.Contains(text) || x.Telefone2.Contains(text) || x.Email.Contains(text)).ToList();
            }
        }
    }
}