using System.ComponentModel.DataAnnotations;

namespace Duck_Mail.Models;

public class EmailTemplate
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Subject { get; set; }
    public string HtmlBody { get; set; }
    public string TextBody { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    public DateTime UpdatedDate { get; set; }
    public virtual IEnumerable<CampaignEmailTemplate> CampaignEmailTemplates { get; set; } = [];
}