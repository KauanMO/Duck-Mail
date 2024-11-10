using Duck_Mail.Enums;

namespace Duck_Mail.DTOs.Campaign;

public class OutCampaignDTO(Models.Campaign campaign)
{
    public int Id { get; set; } = campaign.Id;
    public string Name { get; set; } = campaign.Name;
    public string? Description { get; set; } = campaign.Description;
    public CampaignStatus Status { get; set; } = campaign.Status;
    public int SentCount { get; set; } = campaign.SentCount;
    public int TotalCount { get; set; } = campaign.TotalCount;
    public DateTime CreatedDate { get; set; } = campaign.CreatedDate;
    public DateTime ScheduledDate { get; set; } = campaign.ScheduledDate;
}