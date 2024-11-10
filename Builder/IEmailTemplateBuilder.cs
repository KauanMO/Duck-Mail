using Duck_Mail.Models;

namespace Duck_Mail.Builder;

public interface IEmailTemplateBuilder
{
    public IEmailTemplateBuilder SetName(string name);
    public IEmailTemplateBuilder SetSubject(string subject);
    public IEmailTemplateBuilder SetHtmlBody(string htmlBody);
    public IEmailTemplateBuilder SetTextBody(string textBody);
    public IEmailTemplateBuilder SetUpdatedDate(DateTime updateDate);
    public IEmailTemplateBuilder ReBuild(EmailTemplate emailTemplate);
    public EmailTemplate Build();
}