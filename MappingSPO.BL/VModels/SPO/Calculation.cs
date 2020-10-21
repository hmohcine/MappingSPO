using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingSPO.Framework.BL.VModels.SPO
{
    public class Calculation
    {
        public string Status { get; set; }
        public int Nummer { get; set; }
        public string Versie { get; set; }
        public string Naam { get; set; }
        public string Calculator { get; set; }
        public int CalculatorId { get; set; }
        public string Bedrijf { get; set; }
    }
}
