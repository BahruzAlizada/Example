using Core.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Concrete
{
    public class Lesson : IEntity
    {
        public int Id { get; set; }
       

        public string Description { get; set; }

        public ChapterPart ChapterPart { get; set; }
        [ForeignKey("ChapterPart")]
        public int ChapterPartId { get; set; }
    }
}
