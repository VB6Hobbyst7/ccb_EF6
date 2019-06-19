using Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Repository
{
    public class RepositoryPessoaJuridica: RepositoryBase<PessoaJuridica>
    {
        public RepositoryPessoaJuridica():base()
        {

        }

        public PessoaJuridica ObterPorIdEF(Guid id)
        {
            return dbSet.Find(id);
        }

        public override PessoaJuridica ObterPorId(Guid id)
        {

            var con = context.Database.Connection;
            var pessoaJuridica = new List<PessoaJuridica>();
            var sql = "SELECT * FROM PessoaJuridicas f " +
                "LEFT JOIN PessoaJuridica_Endereco x ON x.PessoaJuridicaId = f.Id " +
                "WHERE f.Id = @sid; ";
            con.Query<PessoaJuridica, Endereco, PessoaJuridica>(sql, (f, e) =>
            {
                if (f != null && !pessoaJuridica.Exists(src => src.Id == f.Id))
                {
                    pessoaJuridica.Add(f);
                }
                return pessoaJuridica.FirstOrDefault();
            }, new { sid = id });

            return pessoaJuridica.FirstOrDefault();
        }
    }
}