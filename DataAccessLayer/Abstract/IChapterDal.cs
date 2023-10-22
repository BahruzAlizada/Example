using Core.DataAccess;
using EntityLayer.Concrete;
using EntityLayer.Dtos.ChapterDto;
using System;


namespace DataAccessLayer.Abstract
{
    public interface IChapterDal : IRepositoryBase<Chapter>
    {
        List<ChapterWithChapterPartDto> GetChaptersWithChapterParts();
        ChapterWithChapterPartDto ChapterWithChapterPart(int id);
        List<ChapterListDto> GetChapters();
        ChapterListDto GetChapter(int id);
        void Activity(int id);
    }
}
