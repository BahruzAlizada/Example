using EntityLayer.Dtos.ChapterDto;
using System;


namespace BusinessLayer.Abstract
{
    public interface IChapterService
    {
        List<ChapterWithChapterPartDto> GetChaptersWithChapterParts();
        ChapterWithChapterPartDto ChapterWithChapterPart(int id);
        List<ChapterListDto> GetChapters();
        ChapterListDto GetChapter(int id);
        void Add(ChapterDto chapterDto);
        void Update(ChapterDto chapterDto);
        void Activity(int id);
    }
}
