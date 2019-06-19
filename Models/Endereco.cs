using System;

namespace Models
{
    public class Endereco
    {
        public Endereco()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Cep { get; set; }

        public virtual Pessoa Pessoa { get; set; }
    }
}