using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using Useful.Core.Domain;
using FluentNHibernate.Automapping.Alterations;
using FluentNHibernate.Automapping;

namespace Useful.Core.DataAccess.NHibernate
{    
    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Table("Users");

            Id(u => u.Id);
            Map(u => u.FirstName);
            Map(u => u.LastName);
        }
    }
}
