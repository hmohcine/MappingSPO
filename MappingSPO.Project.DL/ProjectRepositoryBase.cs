using MappingSPO.Framework.DL;
using MappingSPO.Framework.DL.Repository;

namespace MappingSPO.Project.DL
{
    public abstract class ProjectRepositoryBase<TEntity> : RepositoryBase<TEntity, ProjectContext>
        where TEntity : class, new()
    {
    }
}
