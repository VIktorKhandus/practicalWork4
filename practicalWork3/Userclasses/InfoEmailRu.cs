using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static practicalWork3.Userclasses.WFA_SendingEmail;

namespace practicalWork3.Userclasses
{
    internal class InfoEmailRu : InfoEmail
    {
        public InfoEmailRu(StringPair emailAdressTo, string subject, string body)
        : base(emailAdressTo, subject, body)
        {
            SmtpClientAdress = "smtp.mail.ru";
            EmailAdressFrom = new StringPair("viktordusya@mail.ru", "Хандусь Виктор Сергеевич");
            EmailPassword = "hMWqe21nVfACyjG2Lfap";
            Port = -1;
        }

    }
}
