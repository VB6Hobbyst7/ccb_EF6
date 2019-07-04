using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models
{
    public class PessoaFisica
    {
        //public PessoaFisica()
        //{
        //    Id = Guid.NewGuid();
        //Endereco = new List<Endereco>();
        //}
        //public Guid Id { get; set; }
        public int Id { get; set; }
        public string Nome { get; set; }
        //public string RG { get; set; }
        public string CPF { get; set; }

        //public virtual IList<Endereco> Endereco { get; set; }
        public virtual Pessoa Pessoa { get; set; }

        //public void AdicionarEndereco(Endereco endereco)
        //{
        //    Endereco.Add(endereco);
        //}

    }
}