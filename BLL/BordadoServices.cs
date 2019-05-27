using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ccb_ef6
{
    public static class BordadoServices
    {
        public static void AddNewBordado(string Arquivo, string Caminho, decimal Preco)
        {
            using (LoyaltyDB db = new LoyaltyDB())
            {
                db.Bordados.Add(new Bordado
                {
                    Arquivo = Arquivo,
                    Caminho = Caminho,
                    Preco = Preco
                });
            }
        }

        public static List<Bordado> GetAll()
        {
            List<Bordado> list = new List<Bordado>();

            using (LoyaltyDB db = new LoyaltyDB())
            {
                list = db.Bordados.ToList();
            }

            return list;
        }

        public static void AddNew(Bordado Bordado)
        {
            using (LoyaltyDB db = new LoyaltyDB())
            {
                db.Bordados.Add(Bordado);
                db.SaveChanges();
            }
        }

        public static void Update(Bordado Bordado)
        {
            using (LoyaltyDB db = new LoyaltyDB())
            {
                Bordado.ModifiedDate = DateTime.Now;
                db.Entry(Bordado).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public static bool ArquivoExists(string arquivo, string caminho)
        {
            using (LoyaltyDB db = new LoyaltyDB())
            {
                Bordado Bordado = db.Bordados.Where(u => u.Arquivo == arquivo).SingleOrDefault();

                if (Bordado != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public static Bordado FindById(int id)
        {
            Bordado Bordado = null;

            using (LoyaltyDB db = new LoyaltyDB())
            {
                Bordado = db.Bordados.Find(id);

                if (Bordado != null)
                {
                    return Bordado;
                }
            }

            return null;
        }

        public static List<Bordado> FindByBordadoData(string text)
        {
            using (LoyaltyDB db = new LoyaltyDB())
            {
                return db.Bordados.Where(x => x.Nome.Contains(text) || x.Contato_Nome.Contains(text)
                || x.Telefone1.Contains(text) || x.Telefone2.Contains(text) || x.Email.Contains(text)).ToList();
            }
        }
    }
}
