using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace HappierLiving.Appointment.Repository
{
    public abstract class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected IDbConnection con;
                
        public BaseRepository(IConfiguration config)
        {            
            con = new SqlConnection(config["ConnectionStrings:local"]);
        }
        public virtual int Delete(int Id)
        {    
            //TODO: If exists, Get table name attribute of a class.
            string query = $"DELETE FROM {typeof(TEntity).Name} WHERE ID= @Id";
            DynamicParameters param = new DynamicParameters();
            param.Add("@Id", Id);
            return con.Execute(query, param);
        }

        public virtual Task<int> DeleteAsync(int Id)
        {
            string query = $"DELETE FROM {typeof(TEntity).Name} WHERE ID= @Id";
            DynamicParameters param = new DynamicParameters();
            param.Add("@Id", Id);
            return con.ExecuteAsync(query, param);
        }

        public TEntity Find(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> FindAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TEntity>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public TEntity Insert(TEntity item)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> InsertAsync(TEntity item)
        {
            throw new NotImplementedException();
        }

        public TEntity Update(TEntity item)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> UpdateAsync(TEntity item)
        {
            throw new NotImplementedException();
        }
    }
}