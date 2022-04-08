using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace _04._08._2022
{
    class Program
    {

        static void Main(string[] args)
        {
            Product pr = new Product(1, "Water", 20);
            Product pr1 = new Product(2, "Watermelon", 40);
            Product pr2 = new Product(3, "Coffee", 20);

            ProductItem productItem = new ProductItem(1,pr,5, 100) ;
            ProductItem productItem1 = new ProductItem(2,pr1,3,120);
            ProductItem productItem2 = new ProductItem(3,pr2,5,100);
            List<ProductItem> productItems = new List<ProductItem>();
            productItems.Add(productItem);
            List<ProductItem> productItems1 = new List<ProductItem>();
            productItems1.Add(productItem1);
            List<ProductItem> productItems2 = new List<ProductItem>();
            productItems2.Add(productItem2);


            Order order = new Order(productItems,1,200);
            Order order1 = new Order(productItems1,2,300);
            Order order2 = new Order(productItems2,3,400);
            List<Order> orders = new List<Order>();
            orders.Add(order);
            orders.Add(order1);
            orders.Add(order2);

            using (StreamWriter sw = new StreamWriter(@"C:\Users\User\source\repos\04.08.2022\04.08.2022\Files\Json\json1.json"))
            {
                sw.Write(JsonConvert.SerializeObject(orders));
            }
        }
    }
}
