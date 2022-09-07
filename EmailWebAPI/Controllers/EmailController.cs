using EmailWebAPI.Models;
using EmailWebAPI.Services.EmailService;
using Microsoft.AspNetCore.Mvc;

namespace EmailWebAPI.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]

    public class EmailController:ControllerBase
    {
       
            private readonly IEmailService _emailService;
            
            public EmailController(IEmailService emailService)
            {
                _emailService = emailService;
            }
            [HttpPost]
            public IActionResult sendEmail(EmailModel body)

            {
                _emailService.sendEmail(body);
                return Ok();
            }
    }
}


