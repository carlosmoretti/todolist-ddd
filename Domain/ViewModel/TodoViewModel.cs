﻿using Domain.Validations.Todo;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ViewModel
{
    public class TodoViewModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public ValidationResult Validation => new TodoValidation().Validate(this);
    }
}
