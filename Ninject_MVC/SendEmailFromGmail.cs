using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ninject_MVC
{
    public class SendEmailFromGmail : IEmailSender
    {
        public string SendEmail(string to, string subject)
        {
            return "send from Gmail . . .";
        }
    }

    public class SendEmailFromYahoo : IEmailSender
    {
        public string SendEmail(string to, string subject)
        {
            return "send from Yahoo . . .";
        }
    }
}