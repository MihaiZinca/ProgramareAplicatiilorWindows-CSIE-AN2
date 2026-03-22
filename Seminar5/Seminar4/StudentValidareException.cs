using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar4
{
    internal class StudentValidareException:Exception
    {
        //vom face constrcuctor, care apeleaza base(exception) -derivare

        public StudentValidareException(string message) : base(message)
        {

        } 

    }
}
