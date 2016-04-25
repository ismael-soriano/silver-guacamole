using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infraestructure;

namespace Services
{
    public class ServiceBase
    {
        readonly IUnitOfWork _unitOfWork;

        public ServiceBase(IUnitOfWork unitOfWork)
        {
            if (null == unitOfWork)
                throw new ArgumentNullException("unitOfWork");

            _unitOfWork = unitOfWork;
        }

        public int SaveChanges()
        {
            return _unitOfWork.SaveChanges();
        }

        public void Dispose()
        {
            _unitOfWork.Dispose();
        }
    }
}
