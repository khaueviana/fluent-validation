using System;
using System.Collections.Generic;
using FluentValidation.Results;

namespace FluentValidationSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();

            var validator = new CustomerValidator();
            var results = validator.Validate(customer);

            var validationSucceeded = results.IsValid;
            var failures = results.Errors;
        }
    }
}