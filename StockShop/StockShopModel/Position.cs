
namespace StockShop.StockShopModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Position
    {
        public Position()
        {
            this.Employee = new HashSet<Employee>();
        }
    
        public int id { get; set; }
        public string name_salary { get; set; }
        public double salary { get; set; }
        public string charge { get; set; }
    
        public virtual ICollection<Employee> Employee { get; set; }
    }
}
