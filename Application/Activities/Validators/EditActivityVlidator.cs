using System;
using System.Data;
using Application.Activities.Commands;
using Application.Activities.DTOs;
using FluentValidation;

namespace Application.Activities.Validators;

public class EditActivityVlidator : BaseActivityValidator<EditActivity.Command, EditActivityDto>
{
    public EditActivityVlidator() : base(x => x.ActivityDto)
    {
        RuleFor(x => x.ActivityDto.Id).NotEmpty().WithMessage("Id is required");
    }

}
