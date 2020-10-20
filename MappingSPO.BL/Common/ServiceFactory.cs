using Autofac;
using MappingSPO.Framework.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MappingSPO.Framework.BL.Common
{
    public class ServiceFactory : IServiceFactory
    {
        T IServiceFactory.GetService<T>()
        {
            return AutofacContainer.Container.Resolve<T>();
        }
    }
}
