using Core.DataAccess;
using EntityLayer.Concrete;
using EntityLayer.Dtos;
using System;


namespace DataAccessLayer.Abstract
{
    public interface ISubjectDal : IRepositoryBase<Subject>
    {
        List<SubjectDto> GetSubjects();
        SubjectDto GetSubject(int id);
        void Activity(int id);
    }
}
