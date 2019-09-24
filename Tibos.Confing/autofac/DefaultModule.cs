﻿using Autofac;
using Autofac.Extras.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac.Configuration;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System.Reflection;

namespace Tibos.Confing.autofac
{
    public class DefaultModule : Autofac.Module
    {
        //Autofac容器
        protected override void Load(ContainerBuilder builder)
        {


            //拦截器
            //builder.Register(c => new AOPTest());

            //注入类
            //builder.RegisterType<UsersService>().As<UsersIService>().PropertiesAutowired().EnableInterfaceInterceptors();


            //程序集注入
            var IRepository = Assembly.Load("Tibos.IRepository");
            var Repository = Assembly.Load("Tibos.Repository");

            var IServices = Assembly.Load("Tibos.IService");
            var Services = Assembly.Load("Tibos.Service");


            //根据名称约定（仓储层的接口和实现均以Repository结尾），实现服务接口和服务实现的依赖
            builder.RegisterAssemblyTypes(IRepository, Repository)
              .Where(t => t.Name.EndsWith("Repository"))
              .AsImplementedInterfaces().InstancePerLifetimeScope();

            //根据名称约定（服务层的接口和实现均以Service结尾），实现服务接口和服务实现的依赖
            builder.RegisterAssemblyTypes(IServices, Services)
              .Where(t => t.Name.EndsWith("Service"))
              .AsImplementedInterfaces().InstancePerLifetimeScope();




        }
    }
}
