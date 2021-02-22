using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface ICommonOperationServices<T> : IServiceBase<T> where T : class
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        void Add(T entity);

        void Update(T entity);
        void Delete(T entity);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entities"></param>
        void Add(IEnumerable<T> entities);

    }
}
