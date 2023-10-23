using BusinessLayer.Abstract;
using EntityLayer.Dtos.QuetsionDto;
using EntityLayer.Dtos.SubjectDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Example.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class QuetsionsController : ControllerBase
	{
        private readonly IQuetsionService quetsionService;
        public QuetsionsController(IQuetsionService quetsionService)
        {
            this.quetsionService = quetsionService;
        }

		#region GetQuetsions
		[HttpGet("GetQuetsionsAsync/{chapterId}")]
		public async Task<IActionResult> GetQuetsionsAsync(int chapterId)
		{
			var quetsions = quetsionService.GetQuetsionsAsync(chapterId);
			return Ok(quetsions);
		}
		#endregion

		#region Add
		[HttpPost("AddAsync")]
		public async Task<IActionResult> AddAsync(QuetsionDto quetsionDto)
		{
			await quetsionService.AddAsync(quetsionDto);
			return Ok("Ok");
		}
		#endregion

		#region Update
		[HttpPut("UpdateAsync")]
		public async Task<IActionResult> Update(int id, QuetsionDto quetsionDto)
		{
			await quetsionService.UpdateAsync(quetsionDto);
			return Ok("Ok");
		}
		#endregion

		#region Status
		[HttpGet("Activity/{id}")]
		public IActionResult Activity(int id)
		{
			quetsionService.Activity(id);
			return Ok("Ok");
		}
		#endregion
	}
}
