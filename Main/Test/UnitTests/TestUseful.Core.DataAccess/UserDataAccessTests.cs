using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Useful.Core.DataAccess.NHibernate;
using Useful.Core.Domain;

namespace TestUseful.Core.DataAccess
{
    [TestFixture]
    public class UserDataAccessTests
    {
        [Test]
        public void Save_WithUserInstance_InstanceIsPersistedInDatabase()
        {
            using (var session = SessionFactory.Instance.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var user = new User
                    {
                        FirstName = "Thor",
                        LastName = "Stenbæk"
                    };

                    session.Save(user);

                    transaction.Commit();
                }
            }
        }
    }
}
