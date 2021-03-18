using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Warning.Core.Entities;

eusing System;
using System.Collections.Generic;
using System.Text;

namespace Warning.Core.DataAccess.EntitiyFramework
{
    public class EfEntitiyRepository<TEntity, TContext> : IEntityRepository<TEntity>
         where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity get(Expression<Func<TEntity, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
