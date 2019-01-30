﻿using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class ClienteServices
    {
        public static void AddNewCustomer(string Nombre, string ApellidoPaterno, string ApellidoMaterno, string Direccion, string Telefono,
            string Celular, string Correo, string Usuario, string Contrasena)
        {
            using (LoyaltyDB db = new LoyaltyDB())
            {
                db.Customers.Add(new Customer
                {
                    Address = Direccion,
                    Cellphone = Celular,
                    Email = Correo,
                    MaternalLastname = ApellidoMaterno,
                    Names = Nombre,
                    Username = Usuario,
                    Password = Contrasena,
                    PaternalLastname = ApellidoPaterno,
                    Phone = Telefono,
                    CreatedDate = DateTime.Now
                });
            }
        }

        public static List<Cliente> GetAll()
        {
            List<Cliente> list = new List<Cliente>();

            using (LoyaltyDB db = new LoyaltyDB())
            {
                list = db.Clientes.ToList();
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

        public static Cliente FindById(int id)
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

        public static bool UsernameExists(string nome)
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