﻿using Core.DataAccess.EntityFramework;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using EntityLayer.Dtos;
using System;

namespace DataAccessLayer.EntityFramework
{
    public class EFSubjectDal : EfRepositoryBase<Subject, Context>, ISubjectDal
    {
        #region GetSubjects
        public List<SubjectDto> GetSubjects()
        {
            using var context = new Context();

            List<Subject> subjects = context.Subjects.ToList();
            List<SubjectDto> subjectDtos = new List<SubjectDto>();

            foreach (var item in subjects)
            {
                SubjectDto dto = new SubjectDto
                {
                    Id = item.Id,
                    Name = item.Name,
                    Status = item.Status
                };
                subjectDtos.Add(dto);
            }
            return subjectDtos;
        }
        #endregion

        #region GetSubject
        public SubjectDto GetSubject(int id)
        {
            using var context = new Context();

            Subject subject = context.Subjects.FirstOrDefault(x => x.Id == id);
            SubjectDto subjectDto = new SubjectDto
            {
                Id = subject.Id,
                Name = subject.Name,
                Status = subject.Status
            };

            return subjectDto;
        }
        #endregion

        #region Activity
        public void Activity(int id)
        {
            using var context = new Context();

            Subject subject = context.Subjects.FirstOrDefault(x => x.Id == id);

            if (subject.Status)
                subject.Status = false;
            else
                subject.Status = true;

            context.SaveChanges();
        }

        

        
        #endregion
    }
}