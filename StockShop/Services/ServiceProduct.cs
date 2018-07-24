using System;
using StockShop.StockShopModel;

namespace StockShop.StockShopDAL.Services
{
    class ServiceProduct : IEntity<Product>
    {
        public void CreateEntity(Product entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            using (var context = new StockShopEntities())
            {
                context.Product.Add(entity);
                context.SaveChanges();
            }
        }

        public void DeleteEntity(int id)
        {
            using (var context = new StockShopEntities())
            {
                context.Product.Remove(context.Product.Find(id));
                SaveChange();
            }
        }

        public Product GetEntity(int id)
        {
            using (var context = new StockShopEntities())
            {
                var entity = context.Product.Find(id);
                return entity;
            }
        }

        public void UpdateEntity(Product entity)
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
