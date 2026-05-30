using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AcessPack
{
    [Serializable]
    public class Registration 
    {
        public string CompanyName {  get; set; }
        public int NoOfPasses { get; set; }
        public int AccessId {  get; set; }

        public AccessP Pack;

        public Registration(string companyName, int noOfPasses, int accessId)
        {
            CompanyName = companyName;
            NoOfPasses = noOfPasses;
            AccessId = accessId;
        }
        
        public static explicit operator double(Registration r)
        {
            return r.NoOfPasses * r.Pack.Pret;
        }

        
    }
}
