using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._08._2022
{
    class Order
    {
        public int Id { get; set; }
        public List<ProductItem> productItems { get; set; }
        public int Orderprice { get; set; }
        public Order(List<ProductItem> productItems,int id,int orderprice)
        {
            this.productItems = productItems;
            Id = id;
            Orderprice = orderprice;
        }
    }
}
