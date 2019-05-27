using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class LinhaServices
    {
        public static void AddNewLinha(string Nome, string MaterialNome, string MaterialFabricante, string MaterialTipo, int Cor,
            int Estoque_1, int Estoque_2, int Minimo, int Pedido)
        {
            using (LoyaltyDB db = new LoyaltyDB())
            {
                db.Linhas.Add(new Linha
                {
                    Nome = Nome,
                    MaterialNome = MaterialNome,
                    MaterialFabricante = MaterialFabricante,
                    MaterialTipo = MaterialTipo,
                    Cor = Cor,
                    Estoque_1 = Estoque_1,
                    Estoque_2 = Estoque_2,
                    Minimo = Minimo,
                    Pedido = Pedido
                });
            }
        }

        public static List<Linha> GetAll()
        {
            List<Linha> list = new List<Linha>();

            using (LoyaltyDB db = new LoyaltyDB())
            {
                list = db.Linhas.ToList();
            }

            return list;
        }

        public static void AddNew(Linha Linha)
        {
            using (LoyaltyDB db = new LoyaltyDB())
            {
                db.Linhas.Add(Linha);
                db.SaveChanges();
            }
        }

        public static void Update(Linha Linha)
        {
            using (LoyaltyDB db = new LoyaltyDB())
            {
                Linha.ModifiedDate = DateTime.Now;
                db.Entry(Linha).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        public static Linha FindById(string codigo)
        {
            Linha Linha = null;

            using (LoyaltyDB db = new LoyaltyDB())
            {
                Linha = db.Linhas.Find(codigo);

                if (Linha != null)
                {
                    return Linha;
                }
            }

            return null;
        }

        public static List<Linha> FindByLinhaData(string text)
        {
            using (LoyaltyDB db = new LoyaltyDB())
            {
                return db.Linhas.Where(x => x.Codigo.Contains(text) || x.Nome.Contains(text)).ToList();
            }
        }
    }
}
