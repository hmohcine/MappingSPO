using Autofac;
using MappingSPO.Framework.DL.Contracts;

namespace MappingSPO.Framework.DL.Repository
{
    public class DataRepositoryFactory : IDataRepositoryFactory
    {
        T IDataRepositoryFactory.GetDataRepository<T>()
        {
             return AutofacContainer.Container.Resolve<T>();
        }
    }
}