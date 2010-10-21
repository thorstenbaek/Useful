using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;

namespace Useful.Core.DataAccess.NHibernate
{
    public static class SessionFactory
    {
        private static ISessionFactory s_factory;

        public static ISessionFactory Instance
        {
            get { return s_factory ?? CreateSessionFactory(); }
        }

        private static ISessionFactory CreateSessionFactory()
        {
            s_factory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2005.ConnectionString(c => c
                    .Server("localhost")
                    .Database("ThorTest")
                    .Username("sa")
                    .Password("363sjoij")))
                .Mappings(m=>m.FluentMappings.AddFromAssemblyOf<UserMap>())
                .BuildSessionFactory();
            
            return s_factory;
        }        
    }
}
