using EntityLayer.Dtos.ChapterPartDto;
using System;


namespace BusinessLayer.Abstract
{
    public interface IChapterPartService
    {
        ChapterPartWithQuetsionDto GetChapterPartWithQuetsion(int id);
        List<ChapterPartListDto> GetChapterParts();
        ChapterPartListDto GetChapterPart(int id);
        void Add(ChapterPartDto chapterPartDto);
        void Update(ChapterPartDto chapterPartDto);
        void Activity(int id);
    }
}
