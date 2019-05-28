using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class BordadoLinha
    {
        public int BordadoId { get; set; }
        public Bordado Bordado { get; set; }

        public string LinhaCodigo { get; set; }
        public Linha Linha { get; set; }

        public int seq { get; set; }
    }
}
