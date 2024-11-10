using Duck_Mail.Data;
using Microsoft.EntityFrameworkCore;

namespace Duck_Mail.Repositories.Impl;

public class Repository<T> : IRepository<T> where T : class
{
    protected readonly DatabaseContext _context;
    protected readonly DbSet<T> _dbSet;

    public Repository(DatabaseContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }

    public void Add(T entity)
    {
        _dbSet.Add(entity);
        _context.SaveChanges();
    }

    public void Delete(object id)
    {
        var entityFound = GetById(id);

        _dbSet.Remove(entityFound);
        _context.SaveChanges();
    }

    public IEnumerable<T> GetAll()
    {
        return [.. _dbSet];
    }

    public T GetById(object id)
    {
        return _dbSet.Find(id);
    }

    public void Update(T entity)
    {
        _dbSet.Update(entity);
        _context.SaveChanges();
    }
}
