using Core.Entities;
using System;


namespace EntityLayer.Dtos.ChapterPartDto
{
    public class ChapterPartDto : IDto
    {
        public int Id { get; set; }
        public int ChapterId { get; set; }

        public string Name { get; set; }
        public bool Status { get; set; } = true;
    }
}
