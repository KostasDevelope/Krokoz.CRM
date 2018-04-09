using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Krokoz.CRM.Common.Helpers;

namespace Krokoz.CRM.BL.Repositories
{
    public interface IBaseRepository
    {
        ILogWrapper LogWrapper { get; set; }
    }
}
