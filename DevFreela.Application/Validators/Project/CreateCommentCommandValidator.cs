﻿using DevFreela.Application.Features.Commands.ProjectCommands.CreateComment;
using FluentValidation;

namespace DevFreela.Application.Validators.Project;

public class CreateCommentCommandValidator : AbstractValidator<CreateCommentCommand>
{
    public CreateCommentCommandValidator()
    {
        RuleFor(c => c.Content)
            .NotEmpty().WithMessage("{PropertyName} is required.}")
            .Length(3, 250).WithMessage("{PropertyName} must be between 3 and 250 characters.");
        
        RuleFor(c => c.ProjectId)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .GreaterThan(0).WithMessage("{PropertyName} must be greater than zero.");
        
        RuleFor(c => c.UserId)
            .NotEmpty().WithMessage("{PropertyName} is required.")
            .GreaterThan(0).WithMessage("{PropertyName} must be greater than zero.");   
    }
}
