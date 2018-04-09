using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;


namespace Krokoz.CRM.Common.Helpers
{
    public interface ILogWrapper
    {
        ILog Instance { get; set; }
    }
}
