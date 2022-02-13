using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsShop.Data_Class
{
    public class Factor
    {
        public int Id { set; get; }
        public double TotalPrice { set; get; }
        public List<Product> ListProducts;

        public Factor(int i)
        {
            Id = i;
            ListProducts = new List<Product>();
        }
        public void AddProduct(Product p)
        {
            bool t = true;

            foreach (var item in ListProducts)
            {
                if (item == p)
                {
                    item.Number += 1;
                    t = false;
                }
            }
            if (t)
                ListProducts.Add(p);
        }
        public void Remove_Product(int id)
        {
            bool t = false;
            for (int i = 0; i < ListProducts.Count; i++)
            {
                if (ListProducts[i] != null && ListProducts[i].Id == id)
                {
                    if (ListProducts[i].Number > 1)
                        ListProducts[i].Number -= 1;
                    else
                        ListProducts[i] = null;
                }
            }
        }
        public double GetTotalPriceFactor()
        {
            double sum = 0;
            foreach (var item in ListProducts)
            {
                if (item != null)
                    sum += item.TotalPrice();
            }
            return sum;
        }
        public List<Product> GetAllProduct()
        {
            return ListProducts.ToList();
        }
    }
}
