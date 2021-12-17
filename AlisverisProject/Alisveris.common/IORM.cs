using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alisveris.common
{
    public interface IORM<T> where T:class,new()
    {
        List<T> Select();
        int Insert(T entity);
        bool Update(T entity);
        bool Delete(T entity);
    }
}
