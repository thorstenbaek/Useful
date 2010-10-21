
namespace Useful.Core.DataAccess.NHibernate
{
    public class UserDataAccess : BaseDataAccess, IUserDataAccess
    {
        public Domain.User Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public System.Collections.Generic.IList<Domain.User> Find(System.Func<Domain.User, bool> predicate)
        {
            throw new System.NotImplementedException();
        }

        public System.Collections.Generic.IList<Domain.User> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Domain.User Save(Domain.User instance)
        {
            throw new System.NotImplementedException();
        }
    }
}
