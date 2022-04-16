using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Astronaut.user.repository
{
    internal class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class, new()
    {
        private readonly SqlDbContext _sqlDbContext;
        public BaseService(SqlDbContext sqlDbContext)
        {
            _sqlDbContext = sqlDbContext;
        }

        /// <summary>
        /// 添加数据
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<int> Add(TEntity entity)
        {
            _sqlDbContext.Add(entity);
            return await _sqlDbContext.SaveChangesAsync();
        }
        /// <summary>
        /// 查询全部数据
        /// </summary>
        /// <returns></returns>
        public async Task<List<TEntity>> QueryAsync()
        {
            //异步方法
            var data = await _sqlDbContext.Set<TEntity>().ToListAsync();
            return data;
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<int> Detele(Expression<Func<TEntity, bool>> delWhere)
        {
            var listDels = await _sqlDbContext.Set<TEntity>().Where(delWhere).ToListAsync();
            listDels.ForEach(model =>
            {
                _sqlDbContext.Entry(model).State = EntityState.Deleted;
            });
            return _sqlDbContext.SaveChanges();
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public async Task<int> Update(TEntity entity)
        {
            _sqlDbContext.Entry(entity).State = EntityState.Modified;
            return await _sqlDbContext.SaveChangesAsync();
        }

    }
}
