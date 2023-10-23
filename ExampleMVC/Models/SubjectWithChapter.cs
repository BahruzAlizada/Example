﻿
namespace ExampleMVC.Models
{
    public class SubjectWithChapter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; } = true;
        public List<string> Chapters { get; set; }
    }
}
