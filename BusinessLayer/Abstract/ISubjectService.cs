using EntityLayer.Concrete;
using EntityLayer.Dtos;
using System;

namespace BusinessLayer.Abstract
{
    public interface ISubjectService
    {
        void Add(SubjectDto subjectDto);
        void Update(SubjectDto subjectDto);
        List<SubjectDto> GetSubjects();
        SubjectDto GetSubject(int id);
        void Activity(int id);
    }
}
