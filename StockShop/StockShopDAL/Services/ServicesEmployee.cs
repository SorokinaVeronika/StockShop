using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockShop.StockShopDAL.Repository
{
    class ServiceEmployee : IEntity<Employee>
    {
        public void CreateEntity(Employee entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            using (var context = new StockShopEntities())
            {
                context.Employee.Add(entity);

                context.SaveChanges();
            }
        }

        public void DeleteEntity(int id)
        {
            using (var context = new StockShopEntities())
            {
                context.Employee.Remove(context.Employee.Find(id));
                SaveChange();
            }
        }

        public Employee GetEntity(int id)
        {
            using (var context = new StockShopEntities())
            {
                var entity = context.Employee.Find(id);
                return entity;
            }
        }

        public void UpdateEntity(Employee entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            SaveChange();
        }

        private void SaveChange()
        {
            using (var context = new StockShopEntities())
            {
                context.SaveChanges();
            }
        }
    }
}
