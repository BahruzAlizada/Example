using BusinessLayer.Abstract;
using EntityLayer.Dtos.QuetsionDto;
using EntityLayer.Dtos.VariantDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Example.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class VariantsController : ControllerBase
	{
		private readonly IVariantService variantService;
        public VariantsController(IVariantService variantService)
        {
			this.variantService = variantService;
        }

		#region Add
		[HttpPost("AddAsync")]
		public async Task<IActionResult> AddAsync(VariantDto variantDto)
		{
			await variantService.AddAsync(variantDto);
			return Ok("Ok");
		}
		#endregion

		#region Update
		[HttpPut("UpdateAsync")]
		public async Task<IActionResult> Update(int id, VariantDto variantDto)
		{
			await variantService.UpdateAsync(variantDto);
			return Ok("Ok");
		}
		#endregion
	}
}
