using AutoMapper;
using Scharff.Domain.DTO.Contact.GetContactById;
using Scharff.Domain.DTO.Contact.GetContactByIdClient;
using Scharff.Domain.Entities;

namespace Scharff.API.Mappers
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<ContactModel, GetContactByIdClientDTO>()
                            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                            .ForMember(dest => dest.status, opt => opt.MapFrom(src => src.status))
                            .ForMember(dest => dest.client_id, opt => opt.MapFrom(src => src.client_id))
                            .ForMember(dest => dest.description_type_contact, opt => opt.MapFrom(src => src.description_type_contact))
                            .ForMember(dest => dest.description_area_contact, opt => opt.MapFrom(src => src.description_area_contact))
                            .ForMember(dest => dest.full_name, opt => opt.MapFrom(src => src.full_name))
                            .ForMember(dest => dest.comment, opt => opt.MapFrom(src => src.comment))
                            .ForMember(dest => dest.creation_date, opt => opt.MapFrom(src => src.creation_date))
                            .ForMember(dest => dest.modification_date, opt => opt.MapFrom(src => src.modification_date))
                            .ForMember(dest => dest.telephone, opt => opt.MapFrom(src => src.telephone))
                            .ForMember(dest => dest.email, opt => opt.MapFrom(src => src.email));

            CreateMap<ContactModel, GetContactByIdDTO>()
                           .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                           .ForMember(dest => dest.status, opt => opt.MapFrom(src => src.status))
                           .ForMember(dest => dest.client_id, opt => opt.MapFrom(src => src.client_id))
                           .ForMember(dest => dest.type_param, opt => opt.MapFrom(src => src.type_param))
                           .ForMember(dest => dest.area_param, opt => opt.MapFrom(src => src.area_param))
                           .ForMember(dest => dest.full_name, opt => opt.MapFrom(src => src.full_name))
                           .ForMember(dest => dest.comment, opt => opt.MapFrom(src => src.comment))
                           .ForMember(dest => dest.creation_date, opt => opt.MapFrom(src => src.creation_date))
                           .ForMember(dest => dest.modification_date, opt => opt.MapFrom(src => src.modification_date))
                           .ForMember(dest => dest.phones_contact, opt => opt.MapFrom(src => src.phones_contact))
                           .ForMember(dest => dest.emails_contact, opt => opt.MapFrom(src => src.emails_contact))
                           ;
                    

    }

    }
}
