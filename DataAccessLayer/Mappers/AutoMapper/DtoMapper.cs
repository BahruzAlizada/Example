using AutoMapper;
using EntityLayer.Concrete;
using EntityLayer.Dtos.SubjectDto;
using System;

namespace DataAccessLayer.Mappers.AutoMapper
{
    public class DtoMapper : Profile
    {
        public DtoMapper()
        {
            CreateMap<Subject, SubjectDto>().ReverseMap();
        }
    }
}
