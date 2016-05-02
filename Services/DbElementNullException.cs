using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    class DbElementNullException : Exception
    {
        public DbElementNullException(string message) : base(message)
        {

        }
    }
}
