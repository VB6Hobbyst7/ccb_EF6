using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Linha : SharedBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Codigo { get; set; } = "";

        [Required]
        [MaxLength(30)]
        public string Nome { get; set; } = "";

        [MaxLength(20)]
        public string MaterialNome { get; set; } = "";

        [MaxLength(20)]
        public string MaterialFabricante { get; set; } = "";

        [MaxLength(20)]
        public string MaterialTipo { get; set; } = "";

        public int Cor { get; set; } = 0;

        public int Estoque_1 { get; set; } = 0;
        public int Estoque_2 { get; set; } = 0;
        public int Minimo { get; set; } = 0;
        public int Pedido { get; set; } = 0;

        public IList<BordadoLinha> BordadoLinhas { get; set; }

    }
}
