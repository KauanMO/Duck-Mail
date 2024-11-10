using Duck_Mail.DTOs.Campaign;
using Duck_Mail.Models;

namespace Duck_Mail.Service;

public interface ICampaignService
{
    public Campaign CreateCampaign(InCampaignDTO dto);
}