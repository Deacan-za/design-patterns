using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository.DAL
{
  public interface IGenericRepository<T> where T : class, IEntity
  {
    IEnumerable<T> Get(Expression<Func<T, bool>> filter = null,
      Func<IQueryable<T>, IOrderedEnumerable<T>> orderBy = null,
      string includeProperties = "");

    T GetById(object id);
    void Insert(T entity);
    void Update(T entity);
    void Delete(object id);
    void Delete(T entity);
  }
}
