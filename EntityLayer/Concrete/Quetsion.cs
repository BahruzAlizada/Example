using Core.Entities;
using System;

namespace EntityLayer.Concrete
{
    public class Quetsion : IEntity
    {
        public int Id { get; set; }
        public int ChapterPartId { get; set; }

        public string Name { get; set; }
        public bool Status { get; set; } = true;
        public DateTime Created { get; set; } = DateTime.UtcNow.AddHours(4);

        public ChapterPart ChapterPart { get; set; }
        public List<Variant> Variants { get; set; }
        public Answer Answer { get; set; }
    }
}
