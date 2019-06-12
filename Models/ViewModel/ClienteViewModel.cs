using System;
using System.Collections.Generic;

namespace Models.ViewModel
{
    public class ClienteViewModel
    {
        public PessoaViewModel Pessoa { get; set; }
        public PessoaFisicaViewModel PessoaFisica { get; set; }
        public PessoaJuridicaViewModel PessoaJuridica { get; set; }
        public EnderecoViewModel Endereco { get; set; }

        //[FileSize(10240000)]
        //[FileTypes("jpg,jpeg,png")]        
        //public byte[] Foto { get; set; }

        //public List<string> Foto2 { get; set; }
    }
}