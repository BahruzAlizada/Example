using BusinessLayer.Abstract;
using EntityLayer.Dtos.ChapterDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChaptersController : ControllerBase
    {
        private readonly IChapterService chapterService;
        public ChaptersController(IChapterService chapterService)
        {
            this.chapterService = chapterService;
        }

        #region GetChaptersWithChapterParts
        [HttpGet("GetChaptersWithChapterParts")]
        public IActionResult GetChaptersWithChapterParts()
        {
            var chapters = chapterService.GetChaptersWithChapterParts();
            return Ok(chapters);
        }
        #endregion

        #region ChapterWithChapterPart
        [HttpGet("ChapterWithChapterPart/{id}")]
        public IActionResult ChapterWithChapterPart(int id)
        {
            var chapter = chapterService.ChapterWithChapterPart(id);
            return Ok(chapter);
        }
        #endregion

        #region GetChapters
        [HttpGet("GetChapters")]
        public IActionResult GetChapters()
        {
            var chapterLists = chapterService.GetChapters();
            return Ok(chapterLists);
        }
        #endregion

        #region GetChapter
        [HttpGet("GetChapter/{id}")]
        public IActionResult GetChapter(int id)
        {
            var chapterList = chapterService.GetChapter(id);
            return Ok(chapterList);
        }
        #endregion

        #region Add
        [HttpPost("Add")]
        public IActionResult Add(ChapterDto chapterDto)
        {
            chapterService.Add(chapterDto);
            return Ok("OKay");
        }
        #endregion

        #region Update
        [HttpPut("Update")]
        public IActionResult Update(int id, ChapterDto chapterDto)
        {
            chapterService.Update(chapterDto);
            return Ok("Okay");
        }
        #endregion

        #region Activity
        [HttpGet("Activity/{id}")]
        public IActionResult Activity(int id)
        {
            chapterService.Activity(id);
            return Ok("Okay");
        }
        #endregion
    }
}
