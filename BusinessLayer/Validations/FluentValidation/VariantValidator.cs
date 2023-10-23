using EntityLayer.Dtos.VariantDto;
using FluentValidation;
using System;

namespace BusinessLayer.Validations.FluentValidation
{
	public class VariantValidator : AbstractValidator<VariantDto>
	{
        public VariantValidator()
        {
            RuleFor(x=>x.Text).NotEmpty().WithMessage("Text can not be null");
        }
    }
}
