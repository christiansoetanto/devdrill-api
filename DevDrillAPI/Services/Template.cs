using System.Linq;
using System.Threading.Tasks;
using DevDrillAPI.Dto;
using DevDrillAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace DevDrillAPI.Services
{
    public class TemplateService
    {
        private readonly DevDrillDbContext dbContext;

        public TemplateService(DevDrillDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
    }
}