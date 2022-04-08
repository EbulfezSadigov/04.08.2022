using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._08._2022
{
    class ProductItem
    {
        public int Id { get; set; }
        public Product product { get; set; }
        public int Count { get; set; }
        public int TotalPrice { get; set; }
        public ProductItem(int id,Product product ,int count,int totalprice)
        {
            Id = id;
            this.product = product;
            Count = count;
            TotalPrice = totalprice;
        }
    }
}
