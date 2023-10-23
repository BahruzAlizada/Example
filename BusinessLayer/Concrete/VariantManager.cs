using AutoMapper;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.VariantDto;
using System;

namespace BusinessLayer.Concrete
{
	public class VariantManager : IVariantService
	{
		private readonly IVariantDal variantDal;
		private readonly IMapper mapper;
        public VariantManager(IVariantDal variantDal,IMapper mapper)
        {
            this.variantDal = variantDal;
			this.mapper=mapper;
        }


        public async Task AddAsync(VariantDto variantDto)
		{
			var variant = mapper.Map<Variant>(variantDto);
			await variantDal.AddAsync(variant);
		}

		public async Task UpdateAsync(VariantDto variantDto)
		{
			var variant = mapper.Map<Variant>(variantDto);
			await variantDal.UpdateAsync(variant);
		}
	}
}
