using AutoMapper;
using Domain.Entities;
using MVC.WebApi.ViewModel;
namespace MVC.WebApi.AutoMapper
{
    public class ViewModelToDomainMappingProfile: Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }
        protected override void Configure()
        {
            Mapper.CreateMap<Client, ClientViewModel>();
            Mapper.CreateMap<Product, ProductViewModel > ();
        }
    }
}