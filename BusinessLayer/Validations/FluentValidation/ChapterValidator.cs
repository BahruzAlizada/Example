using EntityLayer.Dtos.ChapterDto;
using FluentValidation;
using System;


namespace BusinessLayer.Validations.FluentValidation
{
    public class ChapterValidator : AbstractValidator<ChapterDto>
    {
        public ChapterValidator()
        {
            RuleFor(x=>x.Name).NotEmpty().WithMessage("Name can not be null");
        }
    }
}
