using Championship.Domain.Entities;
using Championship.ViewModels;
using AutoMapper;

namespace Championship.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected void Configure()
        {
         /*   var playerViewModel = new PlayerViewModel(); 
            Mapper.Map<PlayerViewModel, Player>(playerViewModel);*/
        }
    }
}