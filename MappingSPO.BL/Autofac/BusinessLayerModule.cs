using Autofac;

namespace MappingSPO.Framework.DL.Autofac
{
    public class BusinessLayerModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(System.Reflection.Assembly.GetExecutingAssembly()).AsImplementedInterfaces();
            builder.RegisterModule(new DataLayerModule());
            builder.RegisterModule(new MappingSPO.Project.DL.Autofac.DataLayerModule());
        }
    }
}
