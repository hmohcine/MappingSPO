﻿using Autofac;

namespace MappingSPO.Project.DL.Autofac
{
    public class DataLayerModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(System.Reflection.Assembly.GetExecutingAssembly()).AsImplementedInterfaces();
        }
    }
}