using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity.UI.Services;
using MimeKit;



namespace FunOlympicProject.Services
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var emailToSend = new MimeMessage();
            emailToSend.From.Add(MailboxAddress.Parse("sarishmakumal9825@gmail.com"));
            emailToSend.To.Add(MailboxAddress.Parse(email));
            emailToSend.Subject = subject;
            emailToSend.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = htmlMessage };


            //send email
            using (var emailClient = new SmtpClient())
            {
                emailClient.Connect("smtp-relay.sendinblue.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
                emailClient.Authenticate("sarishmakumal9825@gmail.com", "vdXOaDHbS76FyL0G");
                emailClient.Send(emailToSend);
                emailClient.Disconnect(true);

            }
            return Task.CompletedTask;
        }
    }
}

