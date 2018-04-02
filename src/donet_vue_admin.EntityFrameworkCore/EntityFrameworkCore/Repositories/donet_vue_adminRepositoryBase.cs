using Abp.Domain.Entities;
using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Repositories;

namespace donet_vue_admin.EntityFrameworkCore.Repositories
{
    /// <summary>
    /// Base class for custom repositories of the application.
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    /// <typeparam name="TPrimaryKey">Primary key type of the entity</typeparam>
    public abstract class donet_vue_adminRepositoryBase<TEntity, TPrimaryKey> : EfCoreRepositoryBase<donet_vue_adminDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected donet_vue_adminRepositoryBase(IDbContextProvider<donet_vue_adminDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        // Add your common methods for all repositories
    }

    /// <summary>
    /// Base class for custom repositories of the application.
    /// This is a shortcut of <see cref="donet_vue_adminRepositoryBase{TEntity,TPrimaryKey}"/> for <see cref="int"/> primary key.
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    public abstract class donet_vue_adminRepositoryBase<TEntity> : donet_vue_adminRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected donet_vue_adminRepositoryBase(IDbContextProvider<donet_vue_adminDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        // Do not add any method here, add to the class above (since this inherits it)!!!
    }
}
