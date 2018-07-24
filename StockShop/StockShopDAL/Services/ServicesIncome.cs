using System;


namespace StockShop.StockShopDAL.Repository
{
    class ServiceIncome : IEntity<Income>
    {
        public void CreateEntity(Income entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            using (var context = new StockShopEntities())
            {
                context.Income.Add(entity);

                context.SaveChanges();
            }
        }

        public void DeleteEntity(int id)
        {
            using (var context = new StockShopEntities())
            {
                context.Income.Remove(context.Income.Find(id));
                SaveChange();
            }
        }

        public Income GetEntity(int id)
        {
            using (var context = new StockShopEntities())
            {
                var entity = context.Income.Find(id);
                return entity;
            }
        }

        public void UpdateEntity(Income entity)
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
