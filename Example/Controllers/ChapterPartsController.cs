using BusinessLayer.Abstract;
using EntityLayer.Dtos.ChapterPartDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChapterPartsController : ControllerBase
    {
        private readonly IChapterPartService chapterPartService;
        public ChapterPartsController(IChapterPartService chapterPartService)
        {
            this.chapterPartService = chapterPartService;
        }

        #region GetChapterPartWithQuetsion
        [HttpGet("GetChapterPartWithQuetsion")]
        public IActionResult GetChapterPartWithQuetsion(int id)
        {
            var chapterPart = chapterPartService.GetChapterPartWithQuetsion(id);
            return Ok(chapterPart);
        }
        #endregion

        #region GetChapterParts
        [HttpGet("GetChapterParts")]
        public IActionResult GetChapterParts()
        {
            var chapterParts = chapterPartService.GetChapterParts();
            return Ok(chapterParts);
        }
        #endregion

        #region GetChapterPart
        [HttpGet("GetChapterPart")]
        public IActionResult GetChapterPart(int id)
        {
            var chapterPart = chapterPartService.GetChapterPart(id);
            return Ok(chapterPart);
        }
        #endregion

        #region Add
        [HttpPost("Add")]
        public IActionResult Add(ChapterPartDto chapterPartDto)
        {
            chapterPartService.Add(chapterPartDto);
            return Ok("Okay");
        }
        #endregion

        #region Update
        [HttpPut("Update")]
        public IActionResult Update(int id,ChapterPartDto chapterPartdto)
        {
            chapterPartService.Update(chapterPartdto);
            return Ok("Okay");
        }
        #endregion

        #region Activity
        [HttpGet("Activity/{id}")]
        public IActionResult Activity(int id)
        {
            chapterPartService.Activity(id);
            return Ok("Okay");
        }
        #endregion
    }
}
