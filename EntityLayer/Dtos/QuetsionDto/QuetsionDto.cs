using Core.Entities;
using EntityLayer.Concrete;
using System;

namespace EntityLayer.Dtos.QuetsionDto
{
	public class QuetsionDto : IDto
	{
		public int Id { get; set; }
		public int ChapterPartId { get; set; }
		public string Name { get; set; }
	}
}
