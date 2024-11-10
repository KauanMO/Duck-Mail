using Duck_Mail.Builder;
using Duck_Mail.DTOs.EmailTemplate;
using Duck_Mail.Models;
using Duck_Mail.Repositories;

namespace Duck_Mail.Service.Impl;

public class EmailTemplateService(
        IEmailTemplateBuilder builder,
        IEmailTemplateRepository repository
    ) : IEmailTemplateService
{
    private readonly IEmailTemplateBuilder _builder = builder;
    private readonly IEmailTemplateRepository _repository = repository;

    public EmailTemplate CreateEmailTemplate(InEmailTemplateDTO dto)
    {
        EmailTemplate newEmailTemplate = _builder
            .SetName(dto.Name)
            .SetSubject(dto.Subject)
            .SetHtmlBody(dto.HtmlBody)
            .SetTextBody(dto.TextBody)
            .Build();

        _repository.Add(newEmailTemplate);

        return newEmailTemplate;
    }
}