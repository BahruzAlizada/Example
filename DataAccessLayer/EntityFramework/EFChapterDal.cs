using Core.DataAccess.EntityFramework;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using EntityLayer.Dtos.ChapterDto;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccessLayer.EntityFramework;

public class EFChapterDal : EfRepositoryBase<Chapter, Context>, IChapterDal
{

    #region Activity
    public void Activity(int id)
    {
        using var context = new Context();

        var chapter = context.Chapters.SingleOrDefault(x => x.Id == id);
        if (chapter.Status)
            chapter.Status = false;
        else
            chapter.Status = true;

        context.SaveChanges();
    }
    #endregion

    #region ChapterWithChapterPart
    public ChapterWithChapterPartDto ChapterWithChapterPart(int id)
    {
        using var context = new Context();

        Chapter chapter = context.Chapters.Include(x => x.Subject).Include(x => x.ChapterPart).SingleOrDefault(x => x.Id == id);
        ChapterWithChapterPartDto chapterWithChapterPartDto = new ChapterWithChapterPartDto
        {
            Id = chapter.Id,
            Name = chapter.Name,
            Status = chapter.Status,
            Subject = chapter.Subject.Name,
            ChapterPart = context.ChapterParts.Where(x => x.ChapterId == chapter.Id).
            Select(x => new ChapterPart { Name = x.Name, Id = x.Id }).ToList()
        };
        return chapterWithChapterPartDto;
    }
    #endregion

    #region GetChapter
    public ChapterListDto GetChapter(int id)
    {
        using var context = new Context();

        Chapter chapter = context.Chapters.Include(x => x.Subject).SingleOrDefault(x => x.Id == id);
        ChapterListDto chapterList = new ChapterListDto
        {
            Id = chapter.Id,
            Name = chapter.Name,
            Status = chapter.Status,
            Subject = chapter.Subject.Name
        };
        return chapterList;
    }
    #endregion

    #region GetChapters
    public List<ChapterListDto> GetChapters()
    {
        using var context = new Context();

        List<Chapter> chapters = context.Chapters.Include(x => x.Subject).ToList();
        List<ChapterListDto> chapterListDtos = new List<ChapterListDto>();

        foreach (var item in chapters)
        {
            ChapterListDto dto = new ChapterListDto
            {
                Id = item.Id,
                Name = item.Name,
                Status = item.Status,
                Subject = item.Subject.Name
            };
            chapterListDtos.Add(dto);
        }
        return chapterListDtos;
    }
    #endregion

    #region GetChaptersWithChapterParts
    public List<ChapterWithChapterPartDto> GetChaptersWithChapterParts()
    {
        using var context = new Context();

        List<Chapter> chapters = context.Chapters.Include(x => x.Subject).Include(x => x.ChapterPart).ToList();
        List<ChapterWithChapterPartDto> chapterWithChapterPartDtos = new List<ChapterWithChapterPartDto>();

        foreach (var item in chapters)
        {
            ChapterWithChapterPartDto dto = new ChapterWithChapterPartDto
            {
                Id = item.Id,
                Name = item.Name,
                Status = item.Status,
                Subject = item.Subject.Name,
                ChapterPart = context.ChapterParts.Where(x => x.ChapterId == item.Id).
                Select(x => new ChapterPart { Id = x.Id, Name = x.Name }).ToList()
            };
            chapterWithChapterPartDtos.Add(dto);
        }
        return chapterWithChapterPartDtos;
    }
    #endregion
}
