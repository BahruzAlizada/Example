using EntityLayer.Dtos.ChapterPartDto;
using FluentValidation;
using System;


namespace BusinessLayer.Validations.FluentValidation
{
    public class ChapterPartValidator : AbstractValidator<ChapterPartDto>
    {
        public ChapterPartValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name can not be null");
        }
    }
}
