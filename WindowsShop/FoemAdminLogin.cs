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
    public partial class FoemAdminLogin : Form
    {
        public FoemAdminLogin()
        {
            InitializeComponent();
        }

        private void FoemAdminLogin_Load(object sender, EventArgs e)
        {

        }

        private void btn_CreatNewProduct_Click(object sender, EventArgs e)
        {
            groupBox_NewProduct.Enabled = true;
            groupBox_NewAdmin.Enabled = false;
        }

        private void btn_CreatNewAdmin_Click(object sender, EventArgs e)
        {
            groupBox_NewAdmin.Enabled = true;
            groupBox_NewProduct.Enabled = false;
        }

        private void btnCreatNewproduct_Click(object sender, EventArgs e)
        {
            string Name = txtNameNewProduct.Text;
            string Description = txt_DescriptionNewProduct.Text;
            string price_string = txt_PriceNewProduct.Text;
            string entity_string = txt_EntityNewProduct.Text;
            if (IsEmpty(Name, price_string, entity_string))
            {
                int entity = -1;
                double price = -1;
                int.TryParse(entity_string, out entity);
                double.TryParse(price_string, out price);
                if (entity != -1 || price != -1)
                {
                    Product NewProduct = new Product(Name, Description, price, entity);
                    AllData.AddProduct(NewProduct);
                    MessageBox.Show("کالا اضافه شد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNameNewProduct.Text = "";
                    txt_DescriptionNewProduct.Text = "";
                    txt_PriceNewProduct.Text = "";
                    txt_EntityNewProduct.Text = "";
                    groupBox_NewProduct.Enabled = false;
                }
                else
                {
                    string g =(entity == -1) ? "دریافت موجودی کالا دچار مشکل شده است" : "دریافت قیمت کالا دچار مشکل شده است";
                    MessageBox.Show(g, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool IsEmpty(string name, string price, string entity)
        {
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("نام کالا را بنویسید", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrEmpty(price))
            {
                MessageBox.Show("قیمت کالا وارد نشده است !!!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (string.IsNullOrEmpty(entity))
            {
                MessageBox.Show("تعداد کالاهای موجود را مشخص کنید", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnCreatNewAdmin_Click(object sender, EventArgs e)
        {
            string username = txt_UserNameNewAdmin.Text;
            string fullName = txt_FulnameNewAdmin.Text;
            string email = txt_EmailNewAdmin.Text;
            string pasword = txt_PasswordNewAdmin.Text;
            string numberphone = txt_PhoneNumberNewAdmin.Text;
            if (IsEmpty_NewAdmin(username, email, pasword, numberphone))
            {
                Admin newAdmin = new Admin(fullName, username, email, numberphone, pasword);
                AllData.addAdmin(newAdmin);
                MessageBox.Show("ادمین به مجموعه افزوده شد", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_UserNameNewAdmin.Text = "";
                txt_FulnameNewAdmin.Text = "";
                txt_EmailNewAdmin.Text = "";
                txt_PasswordNewAdmin.Text = "";
                txt_PhoneNumberNewAdmin.Text = "";
                groupBox_NewAdmin.Enabled = false;
            }
        }
        private bool IsEmpty_NewAdmin(string username, string email, string paswrod, string numberphone)
        {
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("نام کاربری واید نشده است", "error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("ایمیل را وارد کنید", "error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(paswrod))
            {
                MessageBox.Show("رمز خود را تعیین کنید", "error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(numberphone))
            {
                MessageBox.Show("وارد کردن شماره تلفن همراه اجباری است", "error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btn_Back_FormAdmin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
