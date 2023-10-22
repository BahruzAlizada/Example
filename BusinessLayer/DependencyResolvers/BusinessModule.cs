using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System;


namespace BusinessLayer.DependencyResolvers
{
    public static class BusinessModule
    {
        public static void Load(this IServiceCollection services)
        {
            services.AddScoped<ISubjectService, SubjectManager>();
            services.AddScoped<ISubjectDal, EFSubjectDal>();

            services.AddScoped<IChapterService, ChapterManager>();
            services.AddScoped<IChapterDal, EFChapterDal>();
        }
    }
}
