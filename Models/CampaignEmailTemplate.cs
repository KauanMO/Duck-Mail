using System.ComponentModel.DataAnnotations;

namespace Duck_Mail.Models;

public class CampaignEmailTemplate
{
    [Key]
    public int Id { get; set; }
    public string Url { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    public virtual Campaign Campaign { get; set; }
    public virtual EmailTemplate EmailTemplate { get; set; }
    public virtual IEnumerable<Recipient> Recipients { get; set; } = [];
    public virtual IEnumerable<ClickHistory> ClickHistories { get; set; } = [];
    public virtual IEnumerable<OpenHistory> OpenHistories { get; set; } = [];
}