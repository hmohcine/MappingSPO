using MappingSPO.Framework.DL.Contracts;
using MappingSPO.Project.DL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingSPO.Project.DL.Contracts
{
    public interface IProjectRepository : IRepositoryBase<ProjectEntity>
    {
        IEnumerable<ProjectWerfEntity> GetProjectsWithSite();
        IEnumerable<ProjectEntity> GetAllProjects();
    }
}
