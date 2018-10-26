using AutoMapper;
using Championship.Domain.Entities;
using Championship.ViewModels;

namespace Championship.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModel"; }
        }

        protected void Configure()
        {
            /*var player = new Player();
            Mapper.Map<Player, PlayerViewModel>(player);*/
        }
    }
}