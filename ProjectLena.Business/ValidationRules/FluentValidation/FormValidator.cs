using FluentValidation;
using ProjectLena.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLena.Business.ValidationRules.FluentValidation
{
    public class FormValidator:AbstractValidator<Form>
    {
        public FormValidator()
        {

            RuleFor(x=>x.FormName).NotEmpty().WithMessage("Form Adı Boş Geçilemez.");
            RuleFor(x=>x.Description).MinimumLength(20).WithMessage("Lütfen en az 20 karakter girişi yapın.");
            RuleFor(x=>x.Name).NotEmpty().WithMessage("Ad Boş Geçilemez.");
            RuleFor(x=>x.Surname).NotEmpty().WithMessage("Soyad Boş Geçilemez.");
            
        }
    }
}
