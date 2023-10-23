using Core.Entities;
using System;


namespace EntityLayer.Concrete
{
    public class Variant : IEntity
    {
        public int Id { get; set; }
        public int QuetsionId { get; set; }
        public string Text { get; set; }
        public bool IsCorrect { get; set; }
        public Quetsion Quetsion { get; set; }
    }
}
