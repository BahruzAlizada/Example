using CoreLayer.Entities;
using System;


namespace EntityLayer.Concrete
{
    public class Subject : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; } = true;
        public List<Quetsion> Quetsions { get; set;}
    }
}
