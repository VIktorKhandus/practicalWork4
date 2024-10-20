using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static practicalWork3.Userclasses.WFA_SendingEmail;

namespace practicalWork3.Userclasses
{
    internal class InfoGMail : InfoEmail
    {
        public InfoGMail(StringPair emailAdressTo, string subject, string body)
        : base(emailAdressTo, subject, body)
        {
            SmtpClientAdress = "smtp.gmail.com";
            EmailAdressFrom = new StringPair("is25khandusvs@artcollege.ru", "Хандусь Виктор Сергеевич");
            EmailPassword = "tysi vulw fgwk odbx";
            Port = 587;
        }

    }
}
