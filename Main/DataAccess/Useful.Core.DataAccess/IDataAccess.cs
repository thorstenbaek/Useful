using System;
using System.Collections.Generic;

namespace Useful.Core.DataAccess
{    
    public interface IDataAccess<T> : IDataAccess where T : class
    {
        T Get(int id);
        
        IList<T> Find(Func<T, bool> predicate);

        IList<T> GetAll();

        T Save(T instance);
    }

    public interface IDataAccess { }
}
