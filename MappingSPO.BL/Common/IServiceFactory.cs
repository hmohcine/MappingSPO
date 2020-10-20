namespace MappingSPO.Framework.BL.Common
{
    public interface IServiceFactory
    {
        T GetService<T>() where T : IService;
    }
}
