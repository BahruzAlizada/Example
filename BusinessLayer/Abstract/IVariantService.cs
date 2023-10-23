using EntityLayer.Dtos.VariantDto;
using System;


namespace BusinessLayer.Abstract
{
	public interface IVariantService
	{
		Task AddAsync(VariantDto variantDto);
		Task UpdateAsync(VariantDto variantDto);
	}
}
