using System;
using StockShop.StockShopModel;

namespace StockShop.StockShopDAL.Services
{
    class ServiceUnity : IEntity<Unity>
    {
        public void CreateEntity(Unity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            using (var context = new StockShopEntities())
            {
                context.Unity.Add(entity);
                context.SaveChanges();
            }
        }

        public void DeleteEntity(int id)
        {
            using (var context = new StockShopEntities())
            {
                context.Unity.Remove(context.Unity.Find(id));
                SaveChange();
            }
        }

        public Unity GetEntity(int id)
        {
            using (var context = new StockShopEntities())
            {
                var entity = context.Unity.Find(id);
                return entity;
            }
        }

        public void UpdateEntity(Unity entity)
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
