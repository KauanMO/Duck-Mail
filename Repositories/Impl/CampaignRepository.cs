using Duck_Mail.Data;
using Duck_Mail.Models;

namespace Duck_Mail.Repositories.Impl;

public class CampaignRepository(DatabaseContext context) : Repository<Campaign>(context), ICampaignRepository
{

}