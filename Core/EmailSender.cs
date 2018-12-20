namespace NewsBlogCoreMongo.Core
{
    using System.Threading.Tasks;
    using MailKit.Net.Smtp;
    using MailKit.Security;
    using Microsoft.Extensions.Configuration;
    using MimeKit;

    public class EmailSender : IEmailSender
    {
        private IConfiguration _configuration { get; }

        public EmailSender(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task SendEmailAsync(string email, string subject, string message)
        {
            var from = _configuration.GetSection("MailAccount").Value;
            var pass = _configuration.GetSection("MailPassword").Value;


            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("Administration", from));
            emailMessage.To.Add(new MailboxAddress("", email));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = message
            };

            using (var client = new SmtpClient())
            {
                client.AuthenticationMechanisms.Remove("XOAUTH2");
                await client.ConnectAsync("smtp.gmail.com", 587, SecureSocketOptions.Auto);
                await client.AuthenticateAsync(from, pass);
                await client.SendAsync(emailMessage);

                await client.DisconnectAsync(true);
            }
        }
    }
}