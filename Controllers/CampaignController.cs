using Duck_Mail.DTOs.Campaign;
using Duck_Mail.Service;
using Microsoft.AspNetCore.Mvc;

namespace Duck_Mail.Controllers;

[ApiController]
[Route("[controller]")]
public class CampaignController(
        ICampaignService service
    ) : ControllerBase
{
    private readonly ICampaignService _service = service;

    [HttpPost]
    public IActionResult PostCampaign(InCampaignDTO dto)
    {
        var newCampaign = _service.CreateCampaign(dto);

        return Ok(new OutCampaignDTO(newCampaign));
    }
}