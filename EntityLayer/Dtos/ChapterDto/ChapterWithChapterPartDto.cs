using EntityLayer.Concrete;
using System;

namespace EntityLayer.Dtos.ChapterDto
{
    public class ChapterWithChapterPartDto
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public bool Status { get; set; }

        public string Subject { get; set; }
        public List<ChapterPart> ChapterPart { get; set; }
    }
}
