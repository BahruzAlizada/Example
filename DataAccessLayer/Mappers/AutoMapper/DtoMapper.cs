using AutoMapper;
using EntityLayer.Concrete;
using EntityLayer.Dtos.ChapterDto;
using EntityLayer.Dtos.ChapterPartDto;
using EntityLayer.Dtos.QuetsionDto;
using EntityLayer.Dtos.SubjectDto;
using EntityLayer.Dtos.VariantDto;
using System;

namespace DataAccessLayer.Mappers.AutoMapper
{
    public class DtoMapper : Profile
    {
        public DtoMapper()
        {
            CreateMap<Subject, SubjectDto>().ReverseMap();
            CreateMap<Chapter, ChapterDto>().ReverseMap();
            CreateMap<ChapterPart, ChapterPartDto>().ReverseMap();    
            CreateMap<Quetsion, QuetsionDto>().ReverseMap();
            CreateMap<Variant, VariantDto>().ReverseMap();
        }
    }
}
