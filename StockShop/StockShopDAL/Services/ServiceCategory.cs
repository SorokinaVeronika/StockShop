using System;
using System.Data.Entity;

namespace StockShop.StockShopDAL
{
    public class ServiceCategory : IEntity<Category>
    {

        public Category GetEntity(int id)
        {
            using (var context = new StockShopEntities())
            {
                var entity = context.Category.Find(id);
                return entity;
            }
        }

        public void CreateEntity(Category entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            using (var context = new StockShopEntities())
            {
                context.Category.Add(entity);

                context.SaveChanges();

            }
        }

        public void UpdateEntity(Category entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            SaveChange();
        }

        public void DeleteEntity(int id)
        {
            using (var context = new StockShopEntities())
            {
                context.Category.Remove(context.Category.Find(id));
                SaveChange();
            }
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
