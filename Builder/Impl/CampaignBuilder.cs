using Duck_Mail.Enums;
using Duck_Mail.Models;

namespace Duck_Mail.Builder.Impl;
public class CampaignBuilder : ICampaignBuilder
{
    private Campaign _campaign;

    public CampaignBuilder()
    {
        _campaign = new() { };
    }

    public Campaign Build()
    {
        return _campaign;
    }

    public ICampaignBuilder ReBuild(Campaign campaign)
    {
        _campaign = campaign;

        return this;
    }

    public ICampaignBuilder SetDescription(string description)
    {
        _campaign.Description = description;

        return this;
    }

    public ICampaignBuilder SetName(string name)
    {
        _campaign.Name = name;

        return this;
    }

    public ICampaignBuilder SetScheduledDate(DateTime scheduledDate)
    {
        _campaign.ScheduledDate = scheduledDate;

        return this;
    }

    public ICampaignBuilder SetSentCount(int sentCount)
    {
        _campaign.SentCount = sentCount;

        return this;
    }

    public ICampaignBuilder SetStatus(CampaignStatus status)
    {
        _campaign.Status = status;

        return this;
    }

    public ICampaignBuilder SetTotalCount(int totalCount)
    {
        _campaign.TotalCount = totalCount;

        return this;
    }
}