using MappingSPO.Project.DL.Contracts;
using MappingSPO.Project.DL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingSPO.Project.DL.Repositories
{
    public class ProjectRepository : ProjectRepositoryBase<ProjectEntity>, IProjectRepository
    {
        #region BaseImplementation
        protected override IEnumerable<ProjectEntity> GetEntities(ProjectContext entityContext)
        {
            return entityContext.Projects.AsNoTracking();
        }

        protected override IEnumerable<ProjectEntity> GetEntities(ProjectContext entityContext, System.Linq.Expressions.Expression<Func<ProjectEntity, bool>> filter)
        {
            throw new NotImplementedException();
        }

        protected override ProjectEntity GetEntity(ProjectContext entityContext, object id)
        {
            int projectId = Convert.ToInt32(id);
            return entityContext.Projects.AsNoTracking().Where(x => x.ProjectId == projectId).FirstOrDefault();
        }
        #endregion


        public IEnumerable<ProjectEntity> GetAllProjects()
        {
            using (var entityContext = new ProjectContext())
            {
                return entityContext.Projects.AsNoTracking().ToList();
            }
        }

        public IEnumerable<ProjectWerfEntity> GetProjectsWithSite()
        {
            using (var ctx = new ProjectContext())
            {
                //return ctx.ProjectWerfs
                //    .Include(x => x.Werf)
                //    .Include(x => x.Project)
                //    .ToList();
                return ctx.ProjectWerfs.ToList();
            }
        }
    }
}
