using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HappierLiving.Appointment.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> GetAll();

        Task<IEnumerable<TEntity>> GetAllAsync();

        TEntity Find(int Id);

        Task<TEntity> FindAsync(int Id);

        TEntity Insert(TEntity item);

        Task<TEntity> InsertAsync(TEntity item);

        TEntity Update(TEntity item);

        Task<TEntity> UpdateAsync(TEntity item);

        int Delete(int Id);

        Task<int> DeleteAsync(int Id);





    }
}
