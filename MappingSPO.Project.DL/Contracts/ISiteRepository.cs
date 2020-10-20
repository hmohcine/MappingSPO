using MappingSPO.Framework.DL.Contracts;
using MappingSPO.Project.DL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingSPO.Project.DL.Contracts
{
    public interface ISiteRepository : IRepositoryBase<WerfEntity>
    {
        IEnumerable<WerfEntity> GetAllSites();
    }
}
