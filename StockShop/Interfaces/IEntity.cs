using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockShop.StockShopDAL
{
    public interface IEntity<T>
    {
        T GetEntity(int id);

        void CreateEntity(T entity);

        void UpdateEntity(T entity);

        void DeleteEntity(int id);
    }
}
