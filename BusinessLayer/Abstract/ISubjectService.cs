using EntityLayer.Concrete;
using EntityLayer.Dtos.SubjectDto;
using System;

namespace BusinessLayer.Abstract
{
    public interface ISubjectService
    {
        void Add(SubjectDto subjectDto);
        void Update(SubjectDto subjectDto);
        List<SubjectwithChapterDto> GetSubjectswithChapter();
        SubjectwithChapterDto GetSubjectwithChapter(int id);
        List<SubjectDto> GetSubjects();
        SubjectDto GetSubject(int id);
        void Activity(int id);
    }
}
