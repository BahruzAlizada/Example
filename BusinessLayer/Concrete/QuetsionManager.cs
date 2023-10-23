using AutoMapper;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.QuetsionDto;
using System;

namespace BusinessLayer.Concrete
{
	public class QuetsionManager : IQuetsionService
	{
		private readonly IQuetsionDal quetsionDal;
		private readonly IMapper mapper;
        public QuetsionManager(IQuetsionDal quetsionDal, IMapper mapper)
        {
			this.quetsionDal = quetsionDal;
            this.mapper = mapper;
        }


        public void Activity(int id)
		{
			quetsionDal.Activity(id);
		}

		public async Task AddAsync(QuetsionDto quetsionDto)
		{
			var quetsion = mapper.Map<Quetsion>(quetsionDto);
			await quetsionDal.AddAsync(quetsion);
		}

		public async Task<List<QuetsionListDto>> GetQuetsionsAsync(int chapterId)
		{
			return await quetsionDal.GetQuetsions(chapterId);
		}

		public async Task UpdateAsync(QuetsionDto quetsionDto)
		{
			var quetsion = mapper.Map<Quetsion>(quetsionDto);
			await quetsionDal.UpdateAsync(quetsion);
		}
	}
}
