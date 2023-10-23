using Core.Entities;
using EntityLayer.Concrete;
using System;

namespace EntityLayer.Dtos.ChapterPartDto
{
    public class ChapterPartWithQuetsionDto : IDto
    {
        public int Id { get; set; }
        public string Chapter { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public List<Quetsion> Quetsions { get; set; }
    }
}
