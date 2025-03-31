using GolovicWebApp.Services;
using Microsoft.Extensions.Options;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

public class EmailService
{
    private readonly EmailSettings _emailSettings;

    public EmailService(IOptions<EmailSettings> emailSettings)
    {
        _emailSettings = emailSettings.Value;
    }

    public async Task SendEmailAsync(string subject, string body)
    {
        Console.WriteLine($"SMTP Server: {_emailSettings.SmtpServer}");
        Console.WriteLine($"Port: {_emailSettings.Port}");
        Console.WriteLine($"Sender Email: {_emailSettings.SenderEmail}");


        var smtpClient = new SmtpClient(_emailSettings.SmtpServer)
        {
            Port = _emailSettings.Port,
            Credentials = new NetworkCredential(_emailSettings.SenderEmail, _emailSettings.SenderPassword),
            EnableSsl = _emailSettings.UseSSL
        };

        var mailMessage = new MailMessage
        {
            From = new MailAddress(_emailSettings.SenderEmail),
            Subject = subject,
            Body = body,
            IsBodyHtml = true
        };


        mailMessage.To.Add(_emailSettings.SenderEmail);

        await smtpClient.SendMailAsync(mailMessage);
    }
}
