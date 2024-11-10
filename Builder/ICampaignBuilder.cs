using Duck_Mail.Enums;
using Duck_Mail.Models;

namespace Duck_Mail.Builder;

public interface ICampaignBuilder
{
    public ICampaignBuilder SetName(string name);
    public ICampaignBuilder SetDescription(string description);
    public ICampaignBuilder SetStatus(CampaignStatus status);
    public ICampaignBuilder SetSentCount(int sentCount);
    public ICampaignBuilder SetTotalCount(int totalCount);
    public ICampaignBuilder SetScheduledDate(DateTime scheduledDate);
    public ICampaignBuilder ReBuild(Campaign campaign);
    public Campaign Build();
}