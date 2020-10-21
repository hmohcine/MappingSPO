using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingSPO.Framework.BL.VModels.SPO
{
   public class Project
    {
        public int ProjectState { get; set; }
        public int ProjectNumber { get; set; }
        public string ProjectName { get; set; }
        public string[] Relations { get; set; }
        public int Owner { get; set; }
        public int? ProjectVerantWoordelijke1 { get; set; }
        public int? ProjectVerantWoordelijke2 { get; set; }
    }
}
