using NutriLife.Core.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NutriLife.Interfaces.Data
{
    public interface IRepository<T> where T : Base
    {
        Task<IEnumerable<T>> GetAllAsync();

        Task<T> GetByIdAsync(int id);

        Task<T> SaveAsync(T entity);
    }
}
