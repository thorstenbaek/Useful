using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Useful.Core.DataAccess
{
    public class UserDataAccess : IUserDataAccess
    {
        public Domain.User Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Domain.User> Find(Func<Domain.User, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public IList<Domain.User> GetAll()
        {
            throw new NotImplementedException();
        }

        public Domain.User Save(Domain.User instance)
        {
            throw new NotImplementedException();
        }
    }
}
