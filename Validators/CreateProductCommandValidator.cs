using System;
using CQRS.WebApi.Application.Features.ProductFeatures.Commands;
using FluentValidation;

namespace CQRS.WebApi.Validators
{
    public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommandValidator()
        {
            RuleFor(c => c.Barcode).NotEmpty();
            RuleFor(c => c.Name).NotEmpty();
        }

    }
}
