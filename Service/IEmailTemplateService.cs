using Duck_Mail.DTOs.EmailTemplate;
using Duck_Mail.Models;

namespace Duck_Mail.Service;

public interface IEmailTemplateService
{
    public EmailTemplate CreateEmailTemplate(InEmailTemplateDTO dto);
}