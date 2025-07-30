using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Villa.Entity.Entities;

namespace Villa.Business.Validators
{
    public class QuestionValidator:AbstractValidator<Quest>
    {
        public QuestionValidator()
        {
            RuleFor(x => x.Question).NotEmpty().WithMessage("Soru alanı boş geçilemez.");
            RuleFor(x => x.Question).MinimumLength(10).WithMessage("10 Karakterden az olamaz.");
            RuleFor(x => x.Question).MaximumLength(150).WithMessage("150 Karakterden fazla olamaz.");
            RuleFor(x => x.Answer).NotEmpty().WithMessage("Cevap alanı boş geçilemez.");
            RuleFor(x => x.Answer).MinimumLength(10).WithMessage("10 Karakterden az olamaz.");
            RuleFor(x => x.Answer).MaximumLength(150).WithMessage("150 Karakterden fazla olamaz.");
        }
    }
}
