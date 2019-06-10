﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Models.ViewModel
{
    public class FotoViewModel
    {
        public FotoViewModel()
        {
            Id = Guid.NewGuid();
        }
        [Key]
        public Guid Id { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public Guid Pessoa_Id { get; set; }

        public virtual PessoaViewModel Pessoa { get; set; }
    }
}