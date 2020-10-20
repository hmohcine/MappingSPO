using MappingSPO.Project.DL.Contracts;
using MappingSPO.Project.DL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingSPO.Project.DL.Repositories
{
    public class SiteRepository : ProjectRepositoryBase<WerfEntity>, ISiteRepository
    {
        #region BaseImplementation
        protected override IEnumerable<WerfEntity> GetEntities(ProjectContext entityContext)
        {
            return entityContext.Werfs.AsNoTracking();
        }

        protected override IEnumerable<WerfEntity> GetEntities(ProjectContext entityContext, System.Linq.Expressions.Expression<Func<WerfEntity, bool>> filter)
        {
            throw new NotImplementedException();
        }

        protected override WerfEntity GetEntity(ProjectContext entityContext, object id)
        {
            int SiteId = Convert.ToInt32(id);
            return entityContext.Werfs.AsNoTracking().Where(x => x.WerfId == SiteId).FirstOrDefault();
        }
        #endregion

        public IEnumerable<WerfEntity> GetAllSites()
        {
            using (var entityContext = new ProjectContext())
            {
                return entityContext.Werfs.AsNoTracking().ToList();
            }
        }
    }
}
