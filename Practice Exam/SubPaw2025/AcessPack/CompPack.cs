using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessPack
{
    public class CompPack : IComparer<Registration>
    {
        public int Compare(Registration x, Registration y)
        {
            return string.Compare(x.Pack.Nume, y.Pack.Nume);
        }
    }
}
