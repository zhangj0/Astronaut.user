namespace Astronaut.user.repository
{
    public interface IBaseService<TEntity> where TEntity : class, new()
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Task<int> Add(TEntity entity);
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Task<int> Update(TEntity entity);
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Task<int> Detele(System.Linq.Expressions.Expression<Func<TEntity, bool>> delWhere);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public Task<List<TEntity>> QueryAsync();
    }
}
