using AutoMapper;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.Dtos.SubjectDto;
using System;

namespace BusinessLayer.Concrete
{
    public class SubjectManager : ISubjectService
    {
        private readonly ISubjectDal subjectDal;
        private readonly IMapper mapper;
        public SubjectManager(ISubjectDal subjectDal,IMapper mapper)
        {
            this.subjectDal = subjectDal;
            this.mapper = mapper;
        }

        public void Activity(int id)
        {
            subjectDal.Activity(id);
        }

        public void Add(SubjectDto subjectDto)
        {
            var subject = mapper.Map<Subject>(subjectDto);
            subjectDal.Add(subject);
        }

        public SubjectDto GetSubject(int id)
        {

            return subjectDal.GetSubject(id);
        }

        public List<SubjectDto> GetSubjects()
        {
            return subjectDal.GetSubjects();
        }

        public List<SubjectwithChapterDto> GetSubjectswithChapter()
        {
            return subjectDal.GetSubjectswithChapter();
        }

        public SubjectwithChapterDto GetSubjectwithChapter(int id)
        {
            return subjectDal.GetSubjectwithChapter(id);
        }

        public void Update(SubjectDto subjectDto)
        {
            var subject = mapper.Map<Subject>(subjectDto);
            subjectDal.Update(subject);
        }
    }
}
