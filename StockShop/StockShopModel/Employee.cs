

namespace StockShop.StockShopModel
{
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public Employee()
        {
            this.Income = new HashSet<Income>();
            this.Outcome = new HashSet<Outcome>();
        }
    
        public int id { get; set; }
        public int id_position { get; set; }
        public string fio { get; set; }
        public string address { get; set; }
        public string passport { get; set; }
        public string number_phone { get; set; }
    
        public virtual Position Position { get; set; }
        public virtual ICollection<Income> Income { get; set; }
        public virtual ICollection<Outcome> Outcome { get; set; }
    }
}
