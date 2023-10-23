using EntityLayer.Dtos.QuetsionDto;
using System;


namespace BusinessLayer.Abstract
{
	public interface IQuetsionService
	{
		Task<List<QuetsionListDto>> GetQuetsionsAsync(int chapterId);
		Task AddAsync(QuetsionDto quetsionDto);
		Task UpdateAsync(QuetsionDto quetsionDto);
		void Activity(int id);
	}
}
