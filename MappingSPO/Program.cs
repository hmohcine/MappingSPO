using Autofac;
using MappingSPO.Framework.BL.Common;
using MappingSPO.Framework.DL;
using MappingSPO.Framework.DL.Autofac;
using System;
using System.Windows.Forms;

namespace MappingSPO
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Bootstrap();

            var IServiceFctory = AutofacContainer.Container.Resolve<IServiceFactory>();

            Application.Run(new Form1(IServiceFctory));

            //Application.Run(new Form1());

        }

        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            //Register modules
            builder.RegisterModule(new MapperModule());
            builder.RegisterModule(new BusinessLayerModule());

            builder.RegisterType<Form1>();

            return builder.Build();
        }
        public static void Bootstrap()
        {
            AutofacContainer.Container = Configure();
        }
    }
}
