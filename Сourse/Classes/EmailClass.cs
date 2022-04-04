using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Сourse.Classes
{
    internal class EmailClass
    {
        public static int code { get; set; }
        /// <summary>
        /// Отправляет письмо на почту на почту
        /// </summary>
        /// <param name="email">Почта пользователя</param>
        /// <param name="body">Текст сообщения</param>
        /// <returns></returns>
        public static async Task PushEmail(string email, string body)
        {
            MailAddress from = new MailAddress("spamtestt56@gmail.com", "TEST");
            MailAddress to = new MailAddress(email);
            MailMessage m = new MailMessage(from, to);
            
            m.Subject = "Подтверждение почты";
            m.Body = body + code.ToString();
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential("spamtestt56@gmail.com", "SpamTest2022!");
            smtp.EnableSsl = true;
            await smtp.SendMailAsync(m);
        } 
    }
}
