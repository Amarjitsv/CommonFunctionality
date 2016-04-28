using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base
{
    public interface ICrud<T> where T : class
    {
        /// <summary>
        /// To save or update an item
        /// </summary>
        /// <param name="item">Item to save</param>
        /// <returns></returns>
        bool Save(T item);

        /// <summary>
        /// To delete particular item by id
        /// </summary>
        /// <param name="id">Id on which the data will be deleted</param>
        /// <returns></returns>
        bool Delete(Guid id);

        /// <summary>
        /// To get list of particular items 
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> GetItems();

        /// <summary>
        /// To get list of particular item by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetItemByID(Guid id);
    }
}
