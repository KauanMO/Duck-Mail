namespace Duck_Mail.Repositories;

public interface IRepository<T>
{
    T GetById(object id);
    IEnumerable<T> GetAll();
    void Add(T entity);
    void Update(T entity);
    void Delete(object id);
}