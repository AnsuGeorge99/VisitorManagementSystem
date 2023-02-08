using VisitorManagementSystem.Models.EmailService;

namespace VisitorManagementSystem.BusinessLogic
{
    public interface IMailService
    {
        Task SendEmailAsync(Email email);
    }
}
