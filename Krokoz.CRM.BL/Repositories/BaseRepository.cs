using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Krokoz.CRM.Common.Helpers;
using Krokoz.CRM.DL.EntityModels;

namespace Krokoz.CRM.BL.Repositories
{
    public abstract class BaseRepository : IBaseRepository
    {
        protected BaseRepository()
        {
            DbContextCRM = new DbContextCRM();
        }
        public ILogWrapper LogWrapper { get; set; }
        protected DbContextCRM DbContextCRM { get; set; }
    }
}
