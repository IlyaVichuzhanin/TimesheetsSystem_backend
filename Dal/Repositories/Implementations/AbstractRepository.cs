using Dto.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal.Entities;
using Microsoft.EntityFrameworkCore;
using Npgsql.Internal;

namespace Dal.Repositories.Implementations
{
    public class AbstractRepository<TModel, TPrimaryKey, TEntity> : IRepository<TModel, TPrimaryKey>
        where TModel : class, IDal
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected readonly TimesheetSystemDbContext _context;
        protected readonly DbSet<TEntity> DbSet;
        //protected readonly IConverter<TModel, TPrimaryKey, TEntity> _converter;
        protected IQueryable<TEntity> DbQuery => DbSet.AsNoTracking().IgnoreAutoIncludes();

        public AbstractRepository(TimesheetSystemDbContext context, IConverter<TModel, TPrimaryKey, TEntity> converter)
        {
            _context = context;
            _converter = converter;
            DbSet = context.Set<TEntity>();
        }


        public Task<TModel> AddAsync(TModel model, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<TModel> AddOrUpdateAsync(TModel model, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task Delete(TPrimaryKey id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyCollection<TModel>> GetAllAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<TModel?> GetByIdAsync(TPrimaryKey id, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task SaveChangeAsync(CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }

        public Task<TModel> Update(TModel model, CancellationToken cancellationToken = default)
        {
            throw new NotImplementedException();
        }
    }
}
