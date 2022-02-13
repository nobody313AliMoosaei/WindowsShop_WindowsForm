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
    public partial class ChangePassword_Form : Form
    {
        private Customer _customer;
        public ChangePassword_Form(Customer cus)
        {
            InitializeComponent();
            _customer = cus;
        }

        private void btn_Save_CP_Click(object sender, EventArgs e)
        {
            if (IsEmpty())
            {
                _customer.Password = txt_NewPassword_CP.Text;
                this.Close();
            }
        }
        private bool IsEmpty()
        {
            if (string.IsNullOrEmpty(txt_NewPassword_CP.Text))
            {
                MessageBox.Show("رمز جدید را وارد کنید !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }else if (string.IsNullOrEmpty(txt_OldPassword_CP.Text))
            {
                MessageBox.Show("وارد کردن رمز قدیمی اجباری است !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
