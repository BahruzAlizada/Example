using Core.Entities;
using EntityLayer.Concrete;
using System;


namespace EntityLayer.Dtos.SubjectDto
{
    public class SubjectwithChapterDto : IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; } = true;
        public List<Chapter> Chapters { get; set; }
    }
}
