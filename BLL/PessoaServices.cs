﻿using DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using Repository;

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
                db.Pessoas.Add(new Pessoa
                {
                    DataCadastro = DateTime.Now,

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

        public static void AddNew(Pessoa Pessoa)
        {
            using (LoyaltyDB db = new LoyaltyDB())
            {
                db.Pessoas.Add(Pessoa);
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
                Pessoa Pessoa = db.Pessoas.Where(u => u.PessoaFisica.Nome == nome).SingleOrDefault();

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
            Pessoa pessoa = null;
            //Guid guid = new Guid(id);

            using (LoyaltyDB db = new LoyaltyDB())
            {
                pessoa = db.Pessoas.Find(id);

                if (pessoa != null)
                {
                    pessoa.Endereco = db.Enderecos.Find(id);
                    if (pessoa.TipoPessoa == TipoPessoa.Fisica)
                        pessoa.PessoaFisica = db.PessoasFisicas.Find(id);
                    else
                        pessoa.PessoaJuridica = db.PessoasJuridicas.Find(id);
                    return pessoa;
                }
            }

            return null;
        }

        public static List<Pessoa> FindByPessoaData(string text)
        {
            using (LoyaltyDB db = new LoyaltyDB())
            {
                return db.Pessoas.Where(x => x.PessoaFisica.Nome.Contains(text)).ToList();
            }
        }

        public static Pessoa ObterPorId(string id)
        {
            Guid guid = new Guid(id);
            var pessoa = new List<Pessoa>();
            var sql = "SELECT * FROM Pessoas p " +
                "LEFT JOIN PessoasFisicas f ON f.Id = p.Id " +
                "LEFT JOIN Enderecos e ON e.Id = p.EnderecoId " +
                "WHERE p.Id = @sid;" +
                "SELECT * FROM Pessoas p " +
                "LEFT JOIN PessoasJuridicas j ON j.Id = p.Id " +
                "LEFT JOIN Enderecos e ON e.Id = p.EnderecoId " +
                "WHERE p.Id = @sid";
            using (var context = new LoyaltyDB())
            {
                var con = context.Database.Connection;

                using (var multi = con.QueryMultiple(sql, new { sid = guid }))
                {
                    var pessoaFisica = multi.Read<Pessoa, PessoaFisica, Endereco, Pessoa>((p, f, e) =>
                    {
                        if (p != null && !pessoa.Exists(src => src.Id == p.Id))
                        {
                            pessoa.Add(p);
                            pessoa[0].PessoaFisica = f;
                        }
                        if (e != null)
                        {
                            pessoa[0].Endereco = e;
                        }
                        return pessoa.FirstOrDefault();
                    });

                    var pessoaJuridica = multi.Read<Pessoa, PessoaJuridica, Endereco, Pessoa>((p, j, e) =>
                    {
                        if (p != null && !pessoa.Exists(src => src.Id == p.Id))
                        {
                            pessoa.Add(p);

                        }
                        if (pessoa.Count() > 0)
                        {
                            for (int i = 0; i < pessoa.Count(); i++)
                            {
                                if (j != null && pessoa[i].Id == j.Id)
                                {
                                    pessoa[i].PessoaJuridica = j;
                                }
                                if (e != null)
                                {
                                    pessoa[i].Endereco = e;
                                }
                            }
                        }
                        return pessoa.FirstOrDefault();
                    });
                }


                //con.Query<Pessoa, PessoaFisica, Endereco, Pessoa>(sql, (p, f, e) =>
                //{
                //    if (p != null && !pessoa.Exists(src => src.Id == p.Id))
                //    {
                //        pessoa.Add(p);
                //    }
                //    if (pessoa.Count() > 0)
                //    {
                //        for (int i = 0; i < pessoa.Count(); i++)
                //        {
                //            if (f != null && pessoa[i].Id == f.Id)
                //            {
                //                pessoa[i].PessoaFisica = f;
                //            }
                //            if (e != null)
                //            {
                //                pessoa[i].PessoaFisica.Endereco.Add(e);
                //            }
                //        }
                //    }
                //    return pessoa.FirstOrDefault();
                //});

                return pessoa.FirstOrDefault();
            }
        }

        public static List<Pessoa> ObterTodos()
        {
            var pessoa = new List<Pessoa>();
            var sql = "SELECT * FROM Pessoas p " +
                "LEFT JOIN Enderecos e ON e.Id = p.Id " +
                "LEFT JOIN PessoasFisicas f ON f.Id = p.Id " +
                "LEFT JOIN PessoasJuridicas j ON j.Id = p.Id ";

            using (var context = new LoyaltyDB())
            {
                var con = context.Database.Connection;

                con.Query<Pessoa, PessoaFisica, PessoaJuridica, Endereco, Pessoa>(sql, (p, f, j, e) =>
                {
                    if (p != null && !pessoa.Exists(src => src.Id == p.Id))
                    {
                        pessoa.Add(p);
                    }
                    if (pessoa.Count() > 0)
                    {
                        for (int i = 0; i < pessoa.Count(); i++)
                        {
                            if (f != null && pessoa[i].Id == f.Id)
                            {
                                pessoa[i].PessoaFisica = f;
                            }
                            if (j != null && pessoa[i].Id == j.Id)
                            {
                                pessoa[i].PessoaJuridica = j;
                            }

                            if (e != null)
                            {
                                pessoa[0].Endereco = e;
                            }

                        }
                    }
                    return pessoa.FirstOrDefault();
                });
            }

            return pessoa;
        }
    }
}