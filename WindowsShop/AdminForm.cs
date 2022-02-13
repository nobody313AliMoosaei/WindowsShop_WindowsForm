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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btn_Save_CP_Click(object sender, EventArgs e)
        {
            if (IsEmpty())
            {
                var Admins = AllData.GetAllAdmin();
                bool flage = true;
                foreach (var item in Admins)
                {
                    if (item.UserName == txt_UserNameAdmin.Text
                        && item.Password == txt_PasswordAdmin.Text)
                    {
                        FoemAdminLogin fal = new FoemAdminLogin();
                        fal.ShowDialog();
                        flage = false;
                        this.Close();
                    }
                }
                if (flage)
                {
                    MessageBox.Show("چنین ادمینی وجود ندارد", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool IsEmpty()
        {
            if (string.IsNullOrEmpty(txt_PasswordAdmin.Text))
            {
                MessageBox.Show("رمز را وارد کنید", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }else if (string.IsNullOrEmpty(txt_UserNameAdmin.Text))
            {
                MessageBox.Show("نام کاربری را وارد کنید", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
