using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_Encapsulamento
{
    public class DomainExceptionVlidation : Exception
    {
        public DomainExceptionVlidation(string error) : base(error)
        {
        }

        public static void When(bool hasError, string error)
        {
            if (hasError)
                throw new DomainExceptionVlidation(error);
        }
    }
}
