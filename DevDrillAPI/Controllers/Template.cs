using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using DevDrillAPI.Dto;
using DevDrillAPI.Services;
using System.Collections.Generic;
using System.Linq;


namespace DevDrillAPI.Controllers
{
    [Route("")]
    [ApiController]
    public class TemplateController : ControllerBase
    {
        private readonly TemplateService templateService;

        public TemplateController(TemplateService templateService)
        {
            this.templateService = templateService;
        }
    }
}