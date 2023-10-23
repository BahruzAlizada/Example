using Core.Entities;
using EntityLayer.Concrete;
using System;

namespace EntityLayer.Dtos.QuetsionDto
{
	public class QuetsionListDto : IDto
	{
		public int Id { get; set; }
		public int ChapterPartId { get; set; }
		public string ChapterPartName { get; set; }
		public string Name { get; set; }
		public bool Status { get; set; }
		public DateTime Created { get; set; }

		public List<Variant> Variants { get; set; }
		
	}
}
