using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskSchedulingSystem.Services;

namespace TaskSchedulingSystem.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CSSAPIController : ControllerBase
    {
        CSSFileService Service;

        public CSSAPIController(CSSFileService service)
        {
            Service = service;
        }

        [HttpGet]

        public string Get()
        {
            return Service.getCSSFile();
        }
    }
}
