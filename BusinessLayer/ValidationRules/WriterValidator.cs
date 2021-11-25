using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar adı soyadı boş geçilemez");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail alanı boş bırakılamaz");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girişi yapın");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("İsim kısmı en fazla 50 karakterden oluşabilir");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Parola alanı boş bırakılamaz");
            RuleFor(x => x.WriterPassword).Must(Validation).WithMessage("Parola en az bir büyük harf, bir küçük harf ve en az 1 sayı içermelidir");
        }
        private bool Validation(string arg){
            Regex regex = new Regex(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[0-9])[A-Za-z\d]");
            if(arg != null && regex.IsMatch(arg)==true){
                return true;
            }
            
            else{
                return false;
            }
        }
        
    }
}
