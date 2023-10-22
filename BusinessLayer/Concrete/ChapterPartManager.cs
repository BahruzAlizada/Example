using AutoMapper;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.ChapterPartDto;
using System;

namespace BusinessLayer.Concrete
{
    public class ChapterPartManager : IChapterPartService
    {
        private readonly IChapterPartDal chapterPartDal;
        private readonly IMapper mapper;
        public ChapterPartManager(IChapterPartDal chapterPartDal,IMapper mapper)
        {
            this.chapterPartDal = chapterPartDal;
            this.mapper = mapper;
        }


        public void Activity(int id)
        {
            chapterPartDal.Activity(id);
        }

        public void Add(ChapterPartDto chapterPartDto)
        {
            var chapterPart = mapper.Map<ChapterPart>(chapterPartDto);
            chapterPartDal.Add(chapterPart);
        }

        public ChapterPartListDto GetChapterPart(int id)
        {
            return chapterPartDal.GetChapterPart(id);
        }

        public ChapterPartWithQuetsionDto GetChapterPartWithQuetsion(int id)
        {
            return chapterPartDal.GetChapterPartWithQuetsion(id);
        }

        public List<ChapterPartListDto> GetChapterParts()
        {
            return chapterPartDal.GetChapterParts();
        }

        public void Update(ChapterPartDto chapterPartDto)
        {
            var chapterPart = mapper.Map<ChapterPart>(chapterPartDto);
            chapterPartDal.Update(chapterPart);
        }
    }
}
