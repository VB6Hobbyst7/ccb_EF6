using System;
using System.Collections.Generic;

namespace Models
{
    public class PessoaJuridica
    {
        public PessoaJuridica()
        {
            Id = Guid.NewGuid();
            Endereco = new List<Endereco>();
        }
        public Guid Id { get; set; }
        public string RazaoSocial { get; set; }
        public string CNPJ { get; set; }

        public virtual Pessoa Pessoa { get; set; }
        public virtual IList<Endereco> Endereco { get; set; }

        public void AdicionarEndereco(Endereco endereco)
        {
            Endereco.Add(endereco);
        }

    }
}