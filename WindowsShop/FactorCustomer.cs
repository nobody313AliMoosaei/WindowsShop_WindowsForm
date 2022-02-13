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
    public partial class FactorCustomer : Form
    {
        public Customer customer;
        public FactorCustomer(Customer Customer)
        {
            InitializeComponent();
            this.customer = Customer;
        }

        private void FactorCustomer_Load(object sender, EventArgs e)
        {
         

            lbl_FullName_Factor.Text = customer.FullName;
            lbl_factorId.Text = customer.Factor.Id.ToString();

            // set data in GridView
            dataGridView.Rows.Clear();
            foreach (var item in customer.Factor.GetAllProduct())
            {
                if (item != null)
                {
                    int n = dataGridView.Rows.Add();
                    dataGridView.Rows[n].Cells[0].Value = item.Id.ToString();
                    dataGridView.Rows[n].Cells[1].Value = item.Name;
                    dataGridView.Rows[n].Cells[2].Value = item.Description;
                    dataGridView.Rows[n].Cells[3].Value = item.Price;
                    dataGridView.Rows[n].Cells[4].Value = item.Number;
                }
            }
            lbl_TotalPrice_Factor.Text = customer.Factor.GetTotalPriceFactor().ToString();
        }

        private void dataGridView_Click(object sender, EventArgs e)
        {
            string i = dataGridView.CurrentRow.Cells[0].Value.ToString();
            int id = -1;
            int.TryParse(i, out id);
            if (id != -1)
            {
                customer.Factor.Remove_Product(id);
                MessageBox.Show(string.Format("{0}حذف شد", AllData.GetProductById(id).Name), "حذف!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.FactorCustomer_Load(sender, e);
            }
        }

        private void btn_Exit_Factor_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
