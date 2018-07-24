using System;
using StockShop.StockShopModel;

namespace StockShop.StockShopDAL.Services
{
    class ServicePosition : IEntity<Position>
    {
        public void CreateEntity(Position entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            using (var context = new StockShopEntities())
            {
                context.Position.Add(entity);
                context.SaveChanges();
            }
        }

        public void DeleteEntity(int id)
        {
            using (var context = new StockShopEntities())
            {
                context.Position.Remove(context.Position.Find(id));
                SaveChange();
            }
        }

        public Position GetEntity(int id)
        {
            using (var context = new StockShopEntities())
            {
                var entity = context.Position.Find(id);
                return entity;
            }
        }

        public void UpdateEntity(Position entity)
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
