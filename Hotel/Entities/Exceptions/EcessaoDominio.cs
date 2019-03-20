using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Entities.Exceptions
{
    class EcessaoDominio : ApplicationException
    {
        public EcessaoDominio(string message) : base(message)
        {
        }


    }
}
