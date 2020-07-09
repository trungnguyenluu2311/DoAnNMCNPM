using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API.Models.Repository
{
    public interface IDataRepository<TEntity, TDto>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(string id);
        TDto GetDto(string id);
        void Add(TEntity entity);
        void Update(string id, TEntity entity);
        void Delete(string id);
    }
}
