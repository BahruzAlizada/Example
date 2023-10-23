using Core.Entities;
using System;


namespace EntityLayer.Concrete
{
    public class Chapter : IEntity
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }

        public string Name { get; set; }
        public bool Status { get; set; } = true;

        public Subject Subject { get; set; }
        public List<ChapterPart> ChapterPart { get; set; }
    }
}
