using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjetoDDD.Domain.Interfaces.GenericsInterfaces
{
    public interface IGeneric<T> where T : class
    {
        Task Add(T Objeto);
        Task Update(T Objeto);
        Task Delete(T Objeto);
        Task<T> GetEntityById(int Id);
        Task <List<T>> List();
    }
}
