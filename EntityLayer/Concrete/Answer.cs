using CoreLayer.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Concrete
{
    public class Answer : IEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public Quetsion Quetsion { get; set; }
        [ForeignKey("Quetsion")]
        public int QuetsionId { get; set; }

    }
}
