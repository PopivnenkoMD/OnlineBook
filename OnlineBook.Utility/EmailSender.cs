using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace OnlineBook.Utility
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            // Простейшая заглушка для отправки писем — логирование в консоль
            Console.WriteLine($"Email sent to {email}: {subject}");
            return Task.CompletedTask;
        }
    }
}
