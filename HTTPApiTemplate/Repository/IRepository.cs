using HTTPApiTemplate.Models;
using HTTPApiTemplate.Repository.Argument;

namespace HTTPApiTemplate.Repository;

public interface IRepository<T, TCreateArgument, TUpdateArgument>
    where T : class
    where TCreateArgument : class
    where TUpdateArgument : class
{
    public T Create(TCreateArgument product);
    
    public IEnumerable<T> GetAll();

    public T Get(Guid id);

    public void Delete(Guid id);

    public void Update(TUpdateArgument product);
}