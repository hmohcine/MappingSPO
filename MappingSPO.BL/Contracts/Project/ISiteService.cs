using MappingSPO.Framework.BL.Common;
using MappingSPO.Framework.BL.VModels.Project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingSPO.Framework.BL.Contracts.Project
{
    public interface ISiteService : IService
    {
        List<SiteVM> GetAllSites();
    }
}
