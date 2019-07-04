using System;
using System.ComponentModel.DataAnnotations.Schema;


namespace Models
{
    public class Pessoa
    {
        //public Pessoa()
        //{
        //    Id = Guid.NewGuid();
        //}
        //public Guid Id { get; set; }
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public TipoPessoa TipoPessoa { get; set; }
        public bool Ativo { get; set; }

        public virtual PessoaFisica PessoaFisica { get; set; }
        public virtual PessoaJuridica PessoaJuridica { get; set; }
        [ForeignKey("EnderecoId")]
        public virtual Endereco Endereco { get; set; }
        //public virtual ICollection<Foto> ListaDeFotos { get; set; }

    }
}