using Duck_Mail.DTOs.EmailTemplate;
using Duck_Mail.Service;
using Microsoft.AspNetCore.Mvc;

namespace Duck_Mail.Controllers;

[ApiController]
[Route("[controller]")]
public class EmailTemplateController(
        IEmailTemplateService service
    ) : ControllerBase
{
    private readonly IEmailTemplateService _service = service;

    [HttpPost]
    public IActionResult PostEmailTemplate(InEmailTemplateDTO dto)
    {
        var newEmailTemplate = _service.CreateEmailTemplate(dto);

        return Ok(new OutEmailTemplateDTO(newEmailTemplate));
    }
}