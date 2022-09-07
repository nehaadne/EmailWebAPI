using EmailWebAPI.Models;

namespace EmailWebAPI.Services.EmailService
{
    public interface IEmailService
    {
        void sendEmail(EmailModel request);
    }
}
