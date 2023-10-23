using EntityLayer.Dtos.QuetsionDto;
using FluentValidation;
using System;


namespace BusinessLayer.Validations.FluentValidation
{
	public class QuetsionValidator : AbstractValidator<QuetsionDto>
	{
        public QuetsionValidator()
        {
            RuleFor(x=>x.Name).NotEmpty().WithMessage("Name can not be null");
        }
    }
}
