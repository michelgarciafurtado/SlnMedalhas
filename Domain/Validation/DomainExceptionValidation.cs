using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Validation
{
    public class DomainExceptionValidation:Exception
    {
        public DomainExceptionValidation(string Error):base(Error)
        {
            
        }

        public static void When(bool hasError, string error)
        {
            if (hasError)
                throw new DomainExceptionValidation(error);
        }   
    }
}
