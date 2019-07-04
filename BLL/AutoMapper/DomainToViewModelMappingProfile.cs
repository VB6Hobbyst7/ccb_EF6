using Models;
using AutoMapper;

namespace AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Pessoa, PessoaViewModel>();
            CreateMap<PessoaFisica, PessoaFisicaViewModel>();
            CreateMap<Endereco, EnderecoViewModel>();
            CreateMap<PessoaJuridica, PessoaJuridicaViewModel>();
            //CreateMap<Foto, FotoViewModel>();

        }
    }
}