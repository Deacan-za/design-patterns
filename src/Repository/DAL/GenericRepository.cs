using Repository.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace Repository.DAL
{
  public class GenericRepository<T> : IGenericRepository<T> where T : class, IEntity
  {
    internal RepositoryContext ctx;
    internal DbSet<T> dbSet;

    public GenericRepository(RepositoryContext context)
    {
      ctx = context;
      dbSet = context.Set<T>();
    }

    public virtual IEnumerable<T> Get(Expression<Func<T, bool>> filter = null,
      Func<IQueryable<T>, IOrderedEnumerable<T>> orderBy = null,
      string includeProperties = "")
    {
      IQueryable<T> query = dbSet;

      if(filter != null)
      {
        query = query.Where(filter);
      }

      foreach (var includeProp in includeProperties.Split(new char[] {','}, StringSplitOptions.RemoveEmptyEntries))
      {
        query = query.Include(includeProp);
      }

      if(orderBy != null)
      {
        return orderBy(query).ToList();
      }
      else
      {
        return query.ToList();
      }
    }

    public virtual T GetById(object id)
    {
      return dbSet.Find(id);
    }

    public virtual void Insert(T entity)
    {
      dbSet.Add(entity);
    }

    public virtual void Update(T entity)
    {
      dbSet.Attach(entity);
      ctx.Entry(entity).State = EntityState.Modified;
    }

    public void Delete(object id)
    {
      T entity = dbSet.Find(id);
      Delete(entity);
    }

    public virtual void Delete(T entity)
    {
      if(ctx.Entry(entity).State == EntityState.Deleted)
      {
        dbSet.Attach(entity);
      }
      dbSet.Remove(entity);
    }
  }
}