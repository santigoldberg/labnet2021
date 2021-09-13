using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2
{
    public class CustomException : Exception
    {
        public CustomException() : base("Mensaje de error de mi Custom Exception")
        {
            
        }
    }
}
