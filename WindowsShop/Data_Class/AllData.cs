using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsShop.Data_Class
{
    public static class AllData
    {
        private static int idproduct = 0;
        public static List<Product> AllProduct = new List<Product>()
        {
            new Product(idproduct++,"Laptop Lenovo" ,"the best",235.25 , 10),
            new Product(idproduct++,"Laptop ASUS" ,"the best",250.55,5)
        };
        public static List<Customer> AllCustomer = new List<Customer>();
        public static List<Admin> AllAdmin = new List<Admin>()
        {
            new Admin("Ali_moosaei","123456789")
        };
        public static bool AddProduct(Product product)
        {
            bool t = true;
            product.Id = idproduct + 1;
            idproduct++;
            foreach (var item in AllProduct)
            {
                if (item.Id == product.Id || item.Name == product.Name)
                    t = false;
            }
            if (t)
            {
                AllProduct.Add(product);
                return t;
            }
            else
                return t;
        }
        public static bool AddCustomer(Customer customer)
        {
            bool t = true;
            foreach (var item in AllCustomer)
            {
                if (item.FullName == customer.FullName || item.Email == customer.Email)
                    t = false;
            }
            if (t)
            {
                AllCustomer.Add(customer);
                return t;
            }
            return t;
        }
        public static Product GetProductById(int id)
        {
            foreach (var item in AllProduct)
            {
                if (item.Id == id)
                    return item;
            }
            return null;
        }
        public static Customer GetCustomerByEmailORNumberPhone(string name)
        {
            foreach (var item in AllCustomer)
            {
                if (item.Email.Contains(name) || item.NumberPhone.Contains(name))
                    return item;
            }
            return null;
        }
        public static List<Customer> GetAllCustomer()
        {
            return AllCustomer.ToList();
        }
        public static List<Product> GetAllProduct()
        {
            return AllProduct.ToList();
        }
        public static List<Admin> GetAllAdmin()
        {
            return AllAdmin.ToList();
        }
        public static void addAdmin(Admin admin)
        {
            AllAdmin.Add(admin);
        }
    }
}
