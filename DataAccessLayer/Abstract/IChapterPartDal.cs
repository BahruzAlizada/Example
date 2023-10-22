using Core.DataAccess;
using EntityLayer.Concrete;
using EntityLayer.Dtos.ChapterPartDto;
using System;


namespace DataAccessLayer.Abstract
{
    public interface IChapterPartDal : IRepositoryBase<ChapterPart>
    {
        ChapterPartWithQuetsionDto GetChapterPartWithQuetsion(int id);
        List<ChapterPartListDto> GetChapterParts();
        ChapterPartListDto GetChapterPart(int id);
        void Activity(int id);
    }
}
