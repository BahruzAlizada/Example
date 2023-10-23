using Core.DataAccess.EntityFramework;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using EntityLayer.Dtos.QuetsionDto;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccessLayer.EntityFramework;

public class EFQuetsionDal : EfRepositoryBase<Quetsion, Context>, IQuetsionDal
{
	public void Activity(int id)
	{
		using var context = new Context();

		var quetsion = context.Quetsions.SingleOrDefault(x=>x.Id==id);
		if (quetsion.Status)
			quetsion.Status = false;
		else
			quetsion.Status = true;

		context.SaveChanges();
	}

	public async Task<List<QuetsionListDto>> GetQuetsions(int chapterId)
	{
		using var context = new Context();

		List<Quetsion> quetsions = await context.Quetsions.Include(x => x.ChapterPart).Include(x => x.Variants).ToListAsync();
		quetsions = quetsions.Where(x => x.ChapterPartId == chapterId).ToList();
		List<QuetsionListDto> quetsionListDtos = new List<QuetsionListDto>();

		foreach (var item in quetsions)
		{
			

			QuetsionListDto dto = new QuetsionListDto
			{
				Id = item.Id,
				Name = item.Name,
				ChapterPartId = item.ChapterPartId,
				ChapterPartName=item.ChapterPart.Name,
				Created = item.Created,
				Status = item.Status,
				Variants = context.Variants.Where(x => x.QuetsionId == item.Id).
				Select(x => new Variant { Id = x.Id, Text = x.Text, IsCorrect = x.IsCorrect }).ToList()
			};
			quetsionListDtos.Add(dto);
		}

		return quetsionListDtos;
	}
}
