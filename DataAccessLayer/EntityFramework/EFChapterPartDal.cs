using Core.DataAccess.EntityFramework;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using EntityLayer.Dtos.ChapterPartDto;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccessLayer.EntityFramework;

public class EFChapterPartDal : EfRepositoryBase<ChapterPart, Context>, IChapterPartDal
{
    public void Activity(int id)
    {
        using var context = new Context();

        ChapterPart chapterPart = context.ChapterParts.SingleOrDefault(x => x.Id == id);
        if (chapterPart.Status)
            chapterPart.Status = false;
        else
            chapterPart.Status = true;

        context.SaveChanges();
    }

    public ChapterPartListDto GetChapterPart(int id)
    {
        using var context = new Context();

        ChapterPart chapterPart = context.ChapterParts.Include(x => x.Chapter).SingleOrDefault(x => x.Id == id);
        ChapterPartListDto chapterPartListDto = new ChapterPartListDto
        {
            Id = chapterPart.Id,
            Name = chapterPart.Name,
            Status = chapterPart.Status,
            Chapter = chapterPart.Chapter.Name
        };
        return chapterPartListDto;
    }

    public ChapterPartWithQuetsionDto GetChapterPartWithQuetsion(int id)
    {
        using var context = new Context();

        ChapterPart chapterPart = context.ChapterParts.Include(x => x.Chapter).Include(x => x.Quetsions).SingleOrDefault(x => x.Id == id);
        ChapterPartWithQuetsionDto chapterPartWithQuetsion = new ChapterPartWithQuetsionDto
        {
            Id = chapterPart.Id,
            Chapter = chapterPart.Chapter.Name,
            Name = chapterPart.Name,
            Status = chapterPart.Status,
            Quetsions = context.Quetsions.Where(x => x.ChapterPartId == chapterPart.Id).
            Select(x => new Quetsion { Id = x.Id, Name = x.Name }).ToList()
        };

        return chapterPartWithQuetsion;
    }

    public List<ChapterPartListDto> GetChapterParts()
    {
        using var context = new Context();

        List<ChapterPart> chapterParts = context.ChapterParts.Include(x => x.Chapter).ToList();
        List<ChapterPartListDto> chapterPartListDtos = new List<ChapterPartListDto>();

        foreach (var item in chapterParts)
        {
            ChapterPartListDto dto = new ChapterPartListDto
            {
                Id = item.Id,
                Name = item.Name,
                Status = item.Status,
                Chapter = item.Chapter.Name
            };
            chapterPartListDtos.Add(dto);
        }
        return chapterPartListDtos;
    }
}
