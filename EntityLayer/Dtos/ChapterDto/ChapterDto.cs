using Core.Entities;
using System;


namespace EntityLayer.Dtos.ChapterDto
{
    public class ChapterDto : IDto
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }

        public string Name { get; set; }
        public bool Status { get; set; } = true;
    }
}
