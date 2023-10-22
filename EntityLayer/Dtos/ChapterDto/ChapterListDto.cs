using CoreLayer.Entities;
using EntityLayer.Concrete;
using System;


namespace EntityLayer.Dtos.ChapterDto
{
    public class ChapterListDto : IDto
    {
        public int Id { get; set; }
       
        public string Name { get; set; }
        public bool Status { get; set; }

        public string Subject { get; set; }
    }
}
