using CoreLayer.Entities;
using System;


namespace EntityLayer.Dtos.SubjectDto
{
    public class SubjectDto : IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; } = true;
    }
}
