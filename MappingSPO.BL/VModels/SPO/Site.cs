using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingSPO.Framework.BL.VModels.SPO
{
   public class Site
    {
        public long WerfId { get; set; }
        public int WerfState { get; set; }
        public int WerfNumber { get; set; }
        public string WerfName { get; set; }
        public int ProjectNumber { get; set; }
        public string ProjectName { get; set; }
        public int? VerantWoordelijke1 { get; set; }
        public int? VerantWoordelijke2 { get; set; }
        public string Bedrijf { get; set; }
    }
}
