﻿using DevsCraft.Core.Objects;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cache;
using NHibernate.Tool.hbm2ddl;
using Ninject;
using Ninject.Modules;
using Ninject.Web.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevsCraft.Core
{
    public class RepositoryModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ISessionFactory>().ToMethod(
                e => Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2012.ConnectionString(c => c.FromConnectionStringWithKey("DevsCraftDb")))
                .Cache(c => c.UseQueryCache().ProviderClass<HashtableCacheProvider>())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<Post>())
                .ExposeConfiguration(cfg => new SchemaExport(cfg).Execute(true, true, false))
                .BuildConfiguration()
                .BuildSessionFactory()
                ).InSingletonScope();
            Bind<ISession>().ToMethod((ctx) => ctx.Kernel.Get<ISessionFactory>().OpenSession()).InRequestScope();
        }
    }
}
