using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biciclete
{
    [Serializable]
    public class Bicicleta
    {
        private readonly int codB;
        private string denumireStatieParcare;
        private int kmParcursi;

        public Bicicleta()
        {
        }

        public Bicicleta(int codB, string denumireStatieParcare, int kmParcursi)
        {
            this.codB = codB;
            this.denumireStatieParcare = denumireStatieParcare;
            this.kmParcursi = kmParcursi;
        }

        public int CodB => codB;
        public string DenumireStatieParcare { get => denumireStatieParcare; set => denumireStatieParcare = value; }
        public int KmParcursi { get => kmParcursi; set => kmParcursi = value; }

        public override string ToString()
        {
            return $"{codB}|{denumireStatieParcare}|{kmParcursi}";
        }
    }
}
