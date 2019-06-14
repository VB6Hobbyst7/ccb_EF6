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
                "WHERE e.Id = @Sid; ";
            var endereco = con.QueryFirstOrDefault(sql, new { Sid = id });

            return endereco;
        }
  
        
    }
}