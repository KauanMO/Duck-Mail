namespace Duck_Mail.DTOs.EmailTemplate;

public class InEmailTemplateDTO
{
    public required string Name { get; set; }
    public required string Subject { get; set; }
    public string? HtmlBody { get; set; }
    public string? TextBody { get; set; }
}