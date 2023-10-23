using Core.DataAccess;
using EntityLayer.Concrete;
using EntityLayer.Dtos.QuetsionDto;
using System;


namespace DataAccessLayer.Abstract
{
	public interface IQuetsionDal : IRepositoryBase<Quetsion>
	{
		Task<List<QuetsionListDto>> GetQuetsions(int chapterId);
		void Activity(int id);
	}
}
