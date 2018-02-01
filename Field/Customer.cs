using System.Collections.Generic;

namespace Field
{
    public class Customer
    {
        public int Id;
        public string Name;
        public readonly List<Order> Orders = new List<Order>();
        //use Readonly to have robustness on coding
        //it
        public Customer()
        {
            Orders = new List<Order>();
        }
        public Customer(int id)
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;  

        }

        public void Promote()
        {
           //Orders = new List<Order>(); due to readonly, list order cannot be used here
            //....
        }

    }
}