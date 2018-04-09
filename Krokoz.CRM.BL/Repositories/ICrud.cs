using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krokoz.CRM.BL.Repositories
{
    public interface ICrud
    {
        IQueryable<T> GetAll<T>() where T : class;
        T GetById<T>(long id) where T : class;
        bool Create<T>(T model) where T : class;
        bool Udate<T>(T model) where T : class;
        bool Delete<T>(T model) where T : class;
    }
}
