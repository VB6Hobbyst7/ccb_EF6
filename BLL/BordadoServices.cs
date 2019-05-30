using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BLL
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

        public static void AddNew(Bordado bordado)
        {
            using (LoyaltyDB db = new LoyaltyDB())
            {
                db.Bordados.Add(bordado);
                db.SaveChanges();
            }
        }

        public static void Update(Bordado bordado)
        {
            using (LoyaltyDB db = new LoyaltyDB())
            {
                //Bordado.ModifiedDate = DateTime.Now;
                db.Entry(bordado).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public static bool ArquivoExists(string arquivo, string caminho)
        {
            using (LoyaltyDB db = new LoyaltyDB())
            {
                Bordado bordado = db.Bordados.Where(u => u.Arquivo == arquivo).SingleOrDefault();

                if (bordado != null)
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
            Bordado bordado = null;

            using (LoyaltyDB db = new LoyaltyDB())
            {
                bordado = db.Bordados.Find(id);

                if (bordado != null)
                {
                    return bordado;
                }
            }

            return null;
        }

        public static List<Bordado> FindByBordadoData(string text)
        {
            using (LoyaltyDB db = new LoyaltyDB())
            {
                return db.Bordados.Where(x => x.Arquivo.Contains(text) || x.Descricao.Contains(text)
                || x.ObsPublica.Contains(text) || x.ObsPrivada.Contains(text)).ToList();
            }
        }
    }
}
