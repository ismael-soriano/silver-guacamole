using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface ICustomerService : IDisposable
    {
        void SaveChanges();
        void Add();
        void Substract();
    }
}
