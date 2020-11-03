using AutoMapper;
using Domain.Entities;
using MVC.WebApi.ViewModel;
namespace MVC.WebApi.AutoMapper
{
    public class DomainToViewModelIMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings";  }
        }
        protected override void Configure()
        {
            Mapper.CreateMap<ClientViewModel, Client>();
            Mapper.CreateMap<ProductViewModel, Product>();
        }
    }
}