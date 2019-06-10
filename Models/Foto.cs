using System;

namespace Models
{
    public class Foto
    {
        public Foto()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public Guid Pessoa_Id { get; set; }

        public virtual Pessoa Pessoa { get; set; }
    }
}