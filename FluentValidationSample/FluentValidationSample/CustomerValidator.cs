using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using FluentValidation;

namespace FluentValidationSample
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(customer => customer.Id).GreaterThan(0);
            RuleFor(customer => customer.Name).NotEmpty();
            RuleFor(customer => customer.Surname).NotEmpty().WithMessage("Por favor especifique o Sobrenome");
            RuleFor(customer => customer.Discount).NotEqual(0).When(customer => customer.HasDiscount);
            RuleFor(customer => customer.DocumentId).Length(20, 250);
            RuleFor(customer => customer.Postcode).Matches(new Regex("^\\d{5}-\\d{3}$")).WithMessage("Por favor especifique um valor correto para o CEP");
        }
    }
}