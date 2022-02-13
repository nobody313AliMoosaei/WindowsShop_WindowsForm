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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            groupBox_Login.Enabled = true;
            groupBox_Creat.Enabled = false;
        }

        private void btnCreatNewAccouunt_Click(object sender, EventArgs e)
        {
            groupBox_Creat.Enabled = true;
            groupBox_Login.Enabled = false;
        }

        private void btnEnter_login_Click(object sender, EventArgs e)
        {
            bool t = CheckEmpty();
            if (t)
            {
                Customer customer = 
                    AllData.GetCustomerByEmailORNumberPhone(txtfullName_Login.Text);
                if (customer != null)
                {
                    LoginForm loginForm = new LoginForm(customer);
                    loginForm.ShowDialog();
                    txtfullName_Login.Text = "";
                    txtPassword_Login.Text = "";
                    groupBox_Login.Enabled = false;
                }
                else
                {
                    MessageBox.Show("چنین کاربری وجود ندارد", "خطا",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtfullName_Login.Text = "";
                    txtPassword_Login.Text = "";
                    txtfullName_Login.Focus();
                }
            }
        }
        private bool CheckEmpty()
        {
            if (string.IsNullOrEmpty(txtfullName_Login.Text))
            {
                ShowMessageBox_Error("خطا !!!", "قسمت ایمیل یا شماره تلفن را پر کنید");
                return false;
            }
            else if (string.IsNullOrEmpty(txtPassword_Login.Text))
            {
                ShowMessageBox_Error("خطا !!!", "قسمت پسورد را پر کنید");
                return false;
            }
            return true;
        }

        private void btnCreatNewAccount_Creat_Click(object sender, EventArgs e)
        {
            string fullname = txtFullName_Creat.Text;
            string email = txtEmail_Creat.Text;
            string password = txtPassword_Creat.Text;
            string nationalcode = txtNationalCode_Creat.Text;
            string numberphone = txtNumberPhone_Creat.Text;
            bool t = CheckEmptyField_Creat(fullname, email, password, nationalcode);

            if (t)
            {
                Customer customer = 
                    new Customer(fullname, numberphone, nationalcode, email, password);
                AllData.AddCustomer(customer);

                LoginForm loginform = new LoginForm(customer);
                loginform.ShowDialog();
                txtFullName_Creat.Text = "";
                txtEmail_Creat.Text = "";
                txtPassword_Creat.Text = "";
                txtNationalCode_Creat.Text = "";
                txtNumberPhone_Creat.Text = "";
                groupBox_Creat.Enabled = false;
            }
        }
        private bool CheckEmptyField_Creat(string a, string b, string c, string d)
        {
            if (string.IsNullOrEmpty(a))
            {
                ShowMessageBox_Error("خطا!!", "لطفا نام و نام خانوادگی خود را وارد کنید");
                txtFullName_Creat.Focus();
                return false;
            }else if (string.IsNullOrEmpty(b))
            {
                ShowMessageBox_Error("خطا!!", "لطفا ایمیل خود را وارد کنید");
                txtEmail_Creat.Focus();
                return false;
            }else if (string.IsNullOrEmpty(c))
            {
                ShowMessageBox_Error("خطا!!", "لطفا رمز خود را وارد کنید");
                txtPassword_Creat.Focus();
                return false;
            }else if (string.IsNullOrEmpty(d))
            {
                ShowMessageBox_Error("خطا!!", "لطفا کد ملی خود را وارد کنید");
                txtNationalCode_Creat.Focus();
                return false;
            }
            return true;
        }
        private void ShowMessageBox_Error(string title, string message)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
