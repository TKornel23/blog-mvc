using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net;
using System.Net.Mail;

namespace Blogs;

public class EmailSender : IEmailSender
{
    public Task SendEmailAsync(string email, string subject, string htmlMessage)
    {
        using (SmtpClient smtpClient = new SmtpClient()
        {
            Host = "smtp.office365.com",
            Port = 587,
            UseDefaultCredentials = false,
            DeliveryMethod = SmtpDeliveryMethod.Network,
            Credentials = new NetworkCredential("tkornel@stud.uni-obuda.hu", "Marton51031"),
            TargetName = "STARTTLS/smtp.office365.com",
            EnableSsl = true,
        })
        {
            MailMessage message = new MailMessage()
            {
                From = new MailAddress("tkornel@stud.uni-obuda.hu"),
                Subject = subject,
                IsBodyHtml = true,
                Body = htmlMessage,
                BodyEncoding = System.Text.Encoding.UTF8,
                SubjectEncoding = System.Text.Encoding.UTF8,
            };

            message.To.Add(email);

            smtpClient.Send(message);
        }

        return Task.CompletedTask;
    }
}
