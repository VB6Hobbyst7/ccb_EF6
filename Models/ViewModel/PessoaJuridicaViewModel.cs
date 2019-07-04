using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class PessoaJuridicaViewModel
    {
        public PessoaJuridicaViewModel()
        {
            Id = Guid.NewGuid();
            Endereco = new List<EnderecoViewModel>();
        }
        [Key]
        public Guid Id { get; set; }
        [Display(Name = "Razão Social")]
        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Foi ultrapassado o limite de 150 caracteres")]
        public string RazaoSocial { get; set; }
        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(15, ErrorMessage = "Foi ultrapassado o limite de 15 caracteres")]
        public string CNPJ { get; set; }

        public virtual PessoaViewModel Pessoa { get; set; }
        public virtual ICollection<EnderecoViewModel> Endereco { get; set; }
    }
}