using AutoMapper;
using AutoMapperYt.Models;

namespace AutoMapperYt.Profiles
{
    public class PersonProfile : Profile
    {
        public PersonProfile()
        {
            CreateMap<PersonInputModel, Person>();

            CreateMap<Person, PersonViewModel>()
                .ForMember(pvm => pvm.MaritalStatus, options => options.MapFrom(p => p.MaritalStatus.ToString()));
        }
    }
}
