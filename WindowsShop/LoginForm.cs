using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsShop.Data_Class;

namespace WindowsShop
{
    public partial class LoginForm : Form
    {
        public Customer _customer;
        public LoginForm(Customer C)
        {
            InitializeComponent();
            _customer = C;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // set data customer
            lbl_FullName.Text = _customer.FullName;
            lbl_Email.Text = _customer.Email;
            lbl_NationalCode.Text = _customer.NationalCode;
            lbl_NumberPhone.Text = _customer.NumberPhone;

            // set data DataGridView
            dataGridView1.Rows.Clear();
            var listProduct = AllData.GetAllProduct();
            for (int i = 0; i < listProduct.Count; i++)
            {
                
                int n = dataGridView1.Rows.Add();
                var item = listProduct[i];
                dataGridView1.Rows[n].Cells[0].Value = item.Id;
                dataGridView1.Rows[n].Cells[1].Value = item.Name;
                dataGridView1.Rows[n].Cells[2].Value = item.Description;
                dataGridView1.Rows[n].Cells[3].Value = item.Price;
                dataGridView1.Rows[n].Cells[4].Value = item.Entity;
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            int id = -1;
            int.TryParse(dataGridView1.CurrentRow.Cells[0].Value.ToString(), out id);
            if (id != -1)
            {
                btn_ShowFactor.Enabled = true;
                var product = AllData.GetProductById(id);
                if (product.Entity > 1)
                {
                    AllData.AllProduct.Find(t => t.Id == id).Entity -- ;
                    _customer.Factor.AddProduct(product);
                    string message = string.Format("محصول = {0} به فاکتور اضافه شد", product.Name);
                    MessageBox.Show(message, "اضافه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.LoginForm_Load(sender, e);
                }else
                {
                    MessageBox.Show(" !!! موجودیت این محصول صفر است");
                }
            }else
            {
                MessageBox.Show("محصولی یافت نشد !!!", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ShowFactor_Click(object sender, EventArgs e)
        {
            FactorCustomer fc = new FactorCustomer(_customer);
            fc.ShowDialog();
        }

        private void linklbl_ChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword_Form cpf = new ChangePassword_Form(_customer);
            cpf.ShowDialog();
        }
    }
}
