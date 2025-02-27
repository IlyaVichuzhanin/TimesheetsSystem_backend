﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dto.Dal;
using Task = System.Threading.Tasks.Task;


namespace Dal.Repositories
{
    public interface IRepository<TModel, in TPrimaryKey>
        where TModel : class, IDal
    {
        public Task SaveChangeAsync(CancellationToken cancellationToken = default);
        public Task<TModel?> GetByIdAsync(TPrimaryKey id, CancellationToken cancellationToken = default);
        public Task<IReadOnlyCollection<TModel>> GetAllAsync(CancellationToken cancellationToken = default);
        public Task<TModel> AddAsync(TModel model, CancellationToken cancellationToken = default);
        public Task<TModel> Update(TModel model, CancellationToken cancellationToken = default);
        public Task Delete(TPrimaryKey id, CancellationToken cancellationToken = default);
        public Task<TModel> AddOrUpdateAsync(TModel model, CancellationToken cancellationToken = default);
    }
}
