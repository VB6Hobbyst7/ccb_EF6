using AutoMapper;
using Models;

namespace AutoMapper
{
    internal class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<PessoaViewModel, Pessoa>();
            CreateMap<PessoaFisicaViewModel, PessoaFisica>();
            CreateMap<PessoaJuridicaViewModel, PessoaJuridica>();
            CreateMap<EnderecoViewModel, Endereco>();
            //CreateMap<FotoViewModel, Foto>();

        }
    }
}