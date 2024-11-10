using Duck_Mail.Enums;
using System.ComponentModel.DataAnnotations;

namespace Duck_Mail.Models;

public class Campaign
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public CampaignStatus Status { get; set; }
    public int SentCount { get; set; }
    public int TotalCount { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.Now;
    public DateTime ScheduledDate { get; set; }
    public virtual IEnumerable<CampaignEmailTemplate> CampaignEmailTemplates { get; set; } = [];
}