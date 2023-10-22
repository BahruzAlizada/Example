using CoreLayer.Entities;
using EntityLayer.Concrete;
using System;


namespace EntityLayer.Dtos.ChapterPartDto
{
    public class ChapterPartListDto : IDto
    {
       public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public string Chapter { get; set; }
    }
}
