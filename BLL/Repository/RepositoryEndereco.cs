using Models;
using Dapper;
using System;

namespace Repository
{
    public class RepositoryEndereco: RepositoryBase<Endereco>
    {
        public override Endereco ObterPorId(Guid id)
        {
            var con = context.Database.Connection;
            var sql = "SELECT * FROM Enderecos e " +
                "WHERE e.Id = @sid; ";
            var endereco = con.QuerySingle(sql, new { sid = id });

            return endereco;
        }
  
        
    }
}