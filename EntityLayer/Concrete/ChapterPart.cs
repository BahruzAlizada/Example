using Core.Entities;
using System;

namespace EntityLayer.Concrete
{
    public class ChapterPart : IEntity
    {
        public int Id { get; set; }
        public int ChapterId { get; set; }

        public string Name { get; set; }
        public bool Status { get; set; } = true;

        public List<Quetsion> Quetsions { get; set; }
        public Chapter Chapter { get; set; }
        public Lesson Lesson { get; set; }
    }
}
