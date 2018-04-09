using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Krokoz.CRM.BL.Models;
using Krokoz.CRM.DL.EntityModels;

namespace Krokoz.CRM.BL.Repositories
{
    public class LandingPageRepository : BaseRepository, ILandingPageRepository
    {
        public IQueryable<LoggingLandingPageModel> GatAllLoggingLanding()
        {
            var result = from llp in DbContextCRM.LoggingLandingPages
                         join lpn in DbContextCRM.LandingPageNames on llp.LandingPageNameId equals lpn.Id
                         join lt in DbContextCRM.LandingTypes on llp.LandingTypeId equals lt.Id
                         join user in DbContextCRM.AspNetUserse on llp.UserId equals user.Id into joinUserEmp
                         from user in joinUserEmp.DefaultIfEmpty()
                         orderby llp.Created descending, llp.LandingPageNameId
                         select new LoggingLandingPageModel
                         {
                             PageName = lpn.PageName, 
                             Created = llp.Created,
                             LandingType = lt.Type,
                             UserName = user != null ? user.UserName : string.Empty
                         };
            return result;
        }
        public int InsertLoggingLanding(string userName, string pageName, int type)
        {
            var landingTyp = DbContextCRM.LandingTypes.FirstOrDefault(s => s.Type == type);
            if (landingTyp == null)
            {
                landingTyp = new LandingType
                {
                    Created = DateTime.UtcNow,
                    Type = type
                };
                DbContextCRM.LandingTypes.Add(landingTyp);
            }
            var landingpage = DbContextCRM.LandingPageNames.FirstOrDefault(s => s.PageName == pageName);
            if (landingpage == null)
            {
                landingpage = new LandingPageName
                {
                    Created = DateTime.UtcNow,
                    PageName = pageName
                };
                DbContextCRM.LandingPageNames.Add(landingpage);
            }
            var user = !string.IsNullOrEmpty(userName) ? 
                        DbContextCRM.AspNetUserse.FirstOrDefault(s => s.UserName == userName) : null;
            var loggingLandingPage = new LoggingLandingPage
            {
                LandingPageName = landingpage,
                LandingType = landingTyp,
                Created = DateTime.UtcNow,
                UserId = user != null ? user.Id : string.Empty
            };
            DbContextCRM.LoggingLandingPages.Add(loggingLandingPage);
            return DbContextCRM.SaveChanges();
        }
    }
}
