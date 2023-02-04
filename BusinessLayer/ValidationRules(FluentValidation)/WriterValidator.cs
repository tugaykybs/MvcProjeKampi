using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules_FluentValidation_
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adını boş geçemezsiniz");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Yazar Adını boş geçemezsiniz");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkımda kısmını boş geçemezsiniz");
            RuleFor(x => x.WriterName).MinimumLength(3).WithMessage("Lütfen en az 2 karakter girişi yapın.");
            RuleFor(x => x.WriterSurname).MaximumLength(20).WithMessage("Lütfen 50 karakterden fazla değer girişi yapmayın.");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Ünvan kısmını boş geçemezsiniz");
            //RuleFor(x => x.WriterAbout).Must(IsAboutValid).WithMessage("Hakkında kısmında en az bir defa a harfi kullanılmalıdır");
        }
        //private bool IsAboutValid(string arg)
        //{
        //    try
        //    {
        //        Regex regex = new Regex(@"^(?=.*[a,A])");
        //        return regex.IsMatch(arg);
        //    }
        //    catch (Exception)
        //    {

        //        return false;
        //    }
        //}
    }
}
