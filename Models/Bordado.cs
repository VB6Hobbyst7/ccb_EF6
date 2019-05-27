using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class LinhaUtilizada
    {
        public int ID { get; set; }
        public int Seq { get; set; }

        public int Pontos { get; set; }

        public int Metragem { get; set; }

        public int BordadoID { get; set; }
        public virtual Bordado Bordado { get; set; }
    }

    public class Bordado
    {
        private HashSet<LinhaUtilizada> LinhasUtilizadas;

        public Bordado()
        {
            this.LinhasUtilizadas = new HashSet<LinhaUtilizada>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Arquivo { get; set; }

        [MaxLength(255)]
        public string Caminho { get; set; }

        [MaxLength(50)]
        public string Descricao { get; set; }

        [MaxLength(12)]
        public string Disquete { get; set; }

        [MaxLength(12)]
        public string Bastidor { get; set; }

        public int Grupo_Id { get; set; }

        [DataType("decimal(6,2)")]
        public decimal Preco { get; set; }

        public int Pontos { get; set; }
        public int Cores { get; set; }
        public int Largura { get; set; }
        public int Altura { get; set; }
        public int Metragem { get; set; }

        public bool Aprovado { get; set; }

        public byte[] Imagem { get; set; }

        [MaxLength(1024)]
        public string ObsPublica { get; set; }

        [MaxLength(1024)]
        public string ObsPrivada { get; set; }

    }    

}

