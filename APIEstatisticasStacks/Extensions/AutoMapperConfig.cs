using APIEstatisticasStacks.Business.DTOs;
using APIEstatisticasStacks.Repository.Entitys;
using AutoMapper;

namespace APIEstatisticasStacks.Business.Extensions
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<EstatisticasStackVagas, DadosEstatistica>().ReverseMap();
            CreateMap<Entity, DadosEstatistica>().ReverseMap();
        }
    }
}