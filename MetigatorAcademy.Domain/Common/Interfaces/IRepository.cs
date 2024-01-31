using MetigatorAcademy.Domain.Enums;
using System.Linq.Expressions;

namespace MetigatorAcademy.Domain.Common.Interfaces;

public interface IRepository<T> where T : class
{
    T GetById(int id);
    Task<T> GetByIdAsync(int id);
    IEnumerable<T> GetAll();
    IEnumerable<T> GetAll(string? included);
    Task<IEnumerable<T>> GetAllAsync();
   
    T Find(Expression<Func<T,bool>> match);
    T Find(Expression<Func<T, bool>> match, string[]? includes = null);
    IEnumerable<T> FindAll(Expression<Func<T, bool>> match, string[]? includes =null);
    IEnumerable<T> FindAll(Expression<Func<T, bool>> match, Expression<Func<T,object>> orderBy,
        string orderByDirection =  OrderBy.Ascending, string[]? includes = null);

    T Add(T entity);
    IEnumerable<T> AddRange(IEnumerable<T> entities);
    T Update(T entity);
    T Remove(T entity);

}
