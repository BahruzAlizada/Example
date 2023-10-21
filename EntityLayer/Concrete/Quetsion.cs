using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
