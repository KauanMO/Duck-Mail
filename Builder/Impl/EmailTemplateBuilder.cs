using Duck_Mail.Models;

namespace Duck_Mail.Builder.Impl;

public class EmailTemplateBuilder : IEmailTemplateBuilder
{
    private EmailTemplate _emailTemplate;

    public EmailTemplateBuilder()
    {
        _emailTemplate = new() { };
    }

    public EmailTemplate Build()
    {
        return _emailTemplate;
    }

    public IEmailTemplateBuilder ReBuild(EmailTemplate emailTemplate)
    {
        _emailTemplate = emailTemplate;

        return this;
    }

    public IEmailTemplateBuilder SetHtmlBody(string htmlBody)
    {
        _emailTemplate.HtmlBody = htmlBody;

        return this;
    }

    public IEmailTemplateBuilder SetName(string name)
    {
        _emailTemplate.Name = name;

        return this;
    }

    public IEmailTemplateBuilder SetSubject(string subject)
    {
        _emailTemplate.Subject = subject;

        return this;
    }

    public IEmailTemplateBuilder SetTextBody(string textBody)
    {
        _emailTemplate.TextBody = textBody;

        return this;
    }

    public IEmailTemplateBuilder SetUpdatedDate(DateTime updateDate)
    {
        _emailTemplate.UpdatedDate = updateDate;

        return this;
    }
}