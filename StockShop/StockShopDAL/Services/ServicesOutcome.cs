using System;

namespace StockShop.StockShopDAL.Repository
{
    class ServiceOutcome : IEntity<Outcome>
    {
        public void CreateEntity(Outcome entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            using (var context = new StockShopEntities())
            {
                context.Outcome.Add(entity);
                context.SaveChanges();
            }
        }

        public void DeleteEntity(int id)
        {
            using (var context = new StockShopEntities())
            {
                context.Outcome.Remove(context.Outcome.Find(id));
                SaveChange();
            }
        }

        public Outcome GetEntity(int id)
        {
            using (var context = new StockShopEntities())
            {
                var entity = context.Outcome.Find(id);
                return entity;
            }
        }

        public void UpdateEntity(Outcome entity)
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

