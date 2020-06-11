using Domain.ViewModel;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Validations.Todo
{
    class TodoValidation : AbstractValidator<TodoViewModel>
    {
        public TodoValidation()
        {
            RuleFor(d => d.Date)
                .NotNull()
                .WithMessage("Data não pode ser vazia!");

            RuleFor(d => d.Description)
                .NotNull()
                .WithMessage("Descrição não pode ser vazia!");

            RuleFor(d => d.Title)
                .NotNull()
                .WithMessage("Título não pode ser vazio!");
        }
    }
}
