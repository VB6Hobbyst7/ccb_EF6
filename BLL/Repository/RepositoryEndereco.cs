using Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Repository
{
    public class RepositoryEndereco: RepositoryBase<Endereco>
    {
        public override Endereco ObterPorId(Guid id)
        {
            var con = context.Database.Connection;
            var sql = "SELECT * FROM dbo.Enderecos e " +
                "WHERE e.Id = @sid; ";
            var endereco = con.QuerySingle<Endereco>(sql, new { sid = id });
            
            return endereco;
        }

        
        
    }
}