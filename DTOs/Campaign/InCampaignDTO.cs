using Duck_Mail.Enums;

namespace Duck_Mail.DTOs.Campaign;

public class InCampaignDTO
{
    public required string Name { get; set; }
    public string? Description { get; set; }
    public CampaignStatus Status { get; set; } = CampaignStatus.Pending;
    public int SentCount { get; set; } = 0;
    public int TotalCount { get; set; } = 0;
    public required DateTime ScheduleDate { get; set; }
}