using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Cliente : SharedBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(120)]
        public string Nome { get; set; }

        [MaxLength(20)]
        public string Contato_Funcao { get; set; }

        [MaxLength(50)]
        public string Contato_Nome { get; set; }

        [MaxLength(20)]
        public string Cgc_Cpf { get; set; }

        [MaxLength(20)]
        public string Inscr_Estadual { get; set; }

        public string Endereco { get; set; }

        [MaxLength(20)]
        public string Cidade { get; set; }

        [MaxLength(2)]
        public string Estado { get; set; }

        [MaxLength(9)]
        public string Cep { get; set; }

        [MaxLength(15)]
        public string Telefone1 { get; set; }

        [MaxLength(15)]
        public string Telefone2 { get; set; }

        [MaxLength(15)]
        public string Telefone3 { get; set; }

        [StringLength(60, ErrorMessage = "Longitud máxima del correo debe es {0} caracteres")]
        public string Email { get; set; }

        [MaxLength(512)]
        public string Obs { get; set; }

        [DataType("decimal(6,2)")]
        public decimal Preco_Base { get; set; }

        public override string ToString()
        {
            return string.Format($"({Nome}) {Contato_Nome}");
        }
    }
}
