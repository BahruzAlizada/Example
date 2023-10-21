using EntityLayer.Concrete;
using EntityLayer.Dtos;
using FluentValidation;
using System;


namespace BusinessLayer.Validations.FluentValidation
{
    public class SubjectValidator : AbstractValidator<SubjectDto>
    {
        public SubjectValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name can not be null");
        }
    }
}
