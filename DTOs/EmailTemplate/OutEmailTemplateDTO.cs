namespace Duck_Mail.DTOs.EmailTemplate;

public class OutEmailTemplateDTO(Models.EmailTemplate emailTemplate)
{
    public int Id { get; set; } = emailTemplate.Id;
    public string Name { get; set; } = emailTemplate.Name;
    public string Subject { get; set; } = emailTemplate.Subject;
    public string HtmlBody { get; set; } = emailTemplate.HtmlBody;
    public string TextBody { get; set; } = emailTemplate.TextBody;
    public DateTime CreatedDate { get; set; } = emailTemplate.CreatedDate;
    public DateTime UpdatedDate { get; set; } = emailTemplate.UpdatedDate;
}