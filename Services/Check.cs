using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{
    public static class Check
    {
        public static void ArgumentIsNull(Object argument, string errorMessage)
        {
            if (null == argument)
                throw new ArgumentNullException(errorMessage);
        }

        public static void ElementIsNull(Object element, string errorMessage)
        {
            if (null == element)
                throw new DbElementNullException(errorMessage);
        }
    }
}
