﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class ContactValidator:AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("Mail Alanını boş geçemezsiniz");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu Alanını boş geçemezsiniz");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kulalnıcı Alanını boş geçemezsiniz");
            RuleFor(x => x.Message).NotEmpty().WithMessage("Mesaj Alanını boş geçemezsiniz");
        }
    }
}
