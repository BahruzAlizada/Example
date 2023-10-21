using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.SubjectDto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectsController : ControllerBase
    {
        private readonly ISubjectService subjectService;
        public SubjectsController(ISubjectService subjectService)
        {
            this.subjectService = subjectService;
        }

        #region GetSubjects
        [HttpGet("GetSubjects")]
        public IActionResult GetSubjects()
        {
            List<SubjectDto> subjects = subjectService.GetSubjects();
            return Ok(subjects);
        }
        #endregion

        #region GetSubject
        [HttpGet("GetSubject/{id}")]
        public IActionResult GetSubject(int id)
        {
            var subject = subjectService.GetSubject(id);
            return Ok(subject);
        }
        #endregion

        #region GetSubjectswithChapter
        [HttpGet("GetSubjectswithChapter")]
        public IActionResult GetSubjectswithChapter()
        {
            var results = subjectService.GetSubjectswithChapter();
            return Ok(results);
        }
        #endregion

        #region GetSubjectwithChapter
        [HttpGet("GetSubjectwithChapter/{id}")]
        public IActionResult GetSubjectwithChapter(int id)
        {
            var result = subjectService.GetSubjectwithChapter(id);
            return Ok(result);
        }
        #endregion

        #region Add
        [HttpPost("Add")]
        public IActionResult Add(SubjectDto subjectDto)
        {
            subjectService.Add(subjectDto);
            return Ok("Ok");
        }
        #endregion

        #region Update
        [HttpPut("Update")]
        public IActionResult Update(int id,SubjectDto subjectDto)
        {
            subjectService.Update(subjectDto);
            return Ok("Ok");
        }
        #endregion

        #region Status
        [HttpGet("Activity/{id}")]
        public IActionResult Activity(int id)
        {
            subjectService.Activity(id);
            return Ok("Ok");
        }
        #endregion
    }
}
