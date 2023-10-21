using Core.DataAccess;
using EntityLayer.Concrete;
using EntityLayer.Dtos.SubjectDto;
using System;


namespace DataAccessLayer.Abstract
{
    public interface ISubjectDal : IRepositoryBase<Subject>
    {
        List<SubjectwithChapterDto> GetSubjectswithChapter();
        SubjectwithChapterDto GetSubjectwithChapter(int id);
        List<SubjectDto> GetSubjects();
        SubjectDto GetSubject(int id);
        void Activity(int id);
    }
}
