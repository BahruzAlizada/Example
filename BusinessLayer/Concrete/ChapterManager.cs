using AutoMapper;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.ChapterDto;
using System;

namespace BusinessLayer.Concrete
{
    public class ChapterManager : IChapterService
    {
        private readonly IChapterDal chapterDal;
        private readonly IMapper mapper;
        public ChapterManager(IChapterDal chapterDal,IMapper mapper)
        {
            this.chapterDal = chapterDal;
            this.mapper = mapper;
        }


        public void Activity(int id)
        {
            chapterDal.Activity(id);
        }

        public void Add(ChapterDto chapterDto)
        {
            var chapter = mapper.Map<Chapter>(chapterDto);
            chapterDal.Add(chapter);
        }

        public ChapterWithChapterPartDto ChapterWithChapterPart(int id)
        {
           return chapterDal.ChapterWithChapterPart(id);
        }

        public ChapterListDto GetChapter(int id)
        {
            return chapterDal.GetChapter(id);
        }

        public List<ChapterListDto> GetChapters()
        {
            return chapterDal.GetChapters();
        }

        public List<ChapterWithChapterPartDto> GetChaptersWithChapterParts()
        {
            return chapterDal.GetChaptersWithChapterParts();
        }

        public void Update(ChapterDto chapterDto)
        {
            var chapter = mapper.Map<Chapter>(chapterDto);
            chapterDal.Update(chapter);
        }
    }
}
