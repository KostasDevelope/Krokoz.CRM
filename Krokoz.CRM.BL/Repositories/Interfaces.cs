using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Krokoz.CRM.BL.Enums;
using Krokoz.CRM.BL.Models;
using Krokoz.CRM.DL.EntityModels;

namespace Krokoz.CRM.BL.Repositories
{
    public interface ILandingPageRepository
    {
        IQueryable<LoggingLandingPageModel> GatAllLoggingLanding();
        int InsertLoggingLanding(string userName, string pageName, LandingTypeEnum landingTypeEnum);
    }
}
