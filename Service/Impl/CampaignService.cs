using Duck_Mail.Builder;
using Duck_Mail.DTOs.Campaign;
using Duck_Mail.Models;
using Duck_Mail.Repositories;

namespace Duck_Mail.Service.Impl;

public class CampaignService(
        ICampaignBuilder builder,
        ICampaignRepository repository
    ) : ICampaignService
{
    private readonly ICampaignBuilder _builder = builder;
    private readonly ICampaignRepository _repository = repository;

    public Campaign CreateCampaign(InCampaignDTO dto)
    {
        Campaign newCampaign = _builder
            .SetName(dto.Name)
            .SetDescription(dto.Description)
            .SetScheduledDate(dto.ScheduleDate)
            .SetSentCount(dto.SentCount)
            .SetStatus(dto.Status)
            .SetTotalCount(dto.TotalCount)
            .Build();

        _repository.Add(newCampaign);
        return newCampaign;
    }
}