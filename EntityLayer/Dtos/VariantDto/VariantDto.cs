using Core.Entities;
using System;


namespace EntityLayer.Dtos.VariantDto
{
	public class VariantDto : IDto
	{
		public int Id { get; set; }
		public int QuetsionId { get; set; }
		public string Text { get; set; }
		public bool IsCorrect { get; set; }
	}
}
