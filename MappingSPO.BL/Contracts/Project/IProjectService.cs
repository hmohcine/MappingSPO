using MappingSPO.Framework.BL.Common;
using MappingSPO.Framework.BL.VModels.Project;
using MappingSPO.Project.DL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingSPO.Framework.BL.Contracts.Project
{
    public interface IProjectService : IService
    {
        List<VModels.SPO.Project> GetAllProjects();
    }
}
