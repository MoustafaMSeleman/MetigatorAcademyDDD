using MetigatorAcademy.Domain.Common;
using MetigatorAcademy.Domain.Common.Interfaces;
using MetigatorAcademy.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace MetigatorAcademy.Infrastructure.Repositories;

public class Repository<T> : IRepository<T> where T : class 
{
    private AppDbContext _context;

    public Repository(AppDbContext context)
    {
        _context = context;
    }
    public T GetById(int id)
    {
        return _context.Set<T>().Find(id);
    }
    public async Task<T> GetByIdAsync(int id)
    {
        return await _context.Set<T>().FindAsync(id);
    }
    public IEnumerable<T> GetAll() 
    {
        return _context.Set<T>().ToList();
    }
    public T Find(Expression<Func<T,bool>> match)
    { 
        return _context.Set<T>().SingleOrDefault(match);
    }

    public T Find(Expression<Func<T,bool>> match, string[] includes)
    {
        IQueryable<T> query = _context.Set<T>();
        if(query !=null) 
        {
            foreach(var include in  includes)
                query = query.Include(include);
        }
        return query.SingleOrDefault(match);
    }

    public IEnumerable<T> FindAll(Expression<Func<T,bool>> match, string[] includes)
    {
        IQueryable<T> query = _context.Set<T>();
        if (query != null)
        {
            foreach(var include in includes)    
                query = query.Include(include);
        }

        return query.Where(match).ToList();
    }

    public IEnumerable<T> FindAll(Expression<Func<T, bool>> match, Expression<Func<T, object>> orderBy =null,
        string orderByDirection = OrderBy.Ascending, string[] includes = null)
    {
        IQueryable<T> query = _context.Set<T>().Where(match);
        if (includes != null)
        {
            foreach(var include in includes)
                query = query.Include(include);
        }
        if (orderByDirection != null)
        {
            if (orderByDirection == OrderBy.Ascending)
                query = query.OrderBy(orderBy);
            else
                query =  query.OrderByDescending(orderBy);
        }
        return query.ToList();
    }

    public T Add(T item) 
    {
        _context.Set<T>().Add(item);
        _context.SaveChanges();
        return item;

    }
    public IEnumerable<T> AddRange(IEnumerable<T> items) 
    {
        _context.Set<T>().AddRange(items);
        _context.SaveChanges();
        return items;
    }

    public T Update(T item) 
    {
        _context.Set<T>().Update(item);
        _context.SaveChanges();
        return item;
    }
    public T Remove(T item) 
    {
        _context.Set<T>().Remove(item);
        _context.SaveChanges();
        return item;
    }
}
