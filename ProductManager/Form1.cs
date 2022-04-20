using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductManager
{
    public partial class Form1 : Form
    {
        static IDatabase Database;
        public Form1(string databaseTypestring)
        {

            Database = Utilities.GetDatabase(databaseTypestring);
            InitializeComponent();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (Utilities.ProductValidation(tbxName.Text,tbxPrice.Text,tbxStockAmount.Text))
            {
                Database.Add(new Product
                {
                    Name = tbxName.Text,
                    Price = Convert.ToDecimal(tbxPrice.Text),
                    StockAmount = Convert.ToInt32(tbxStockAmount.Text)
                }
            );
                tbxName.Text = "";
                tbxPrice.Text = "";
                tbxStockAmount.Text = "";
                dgvProducts.DataSource = Database.GetProducts();
            }
            else
            {
                MessageBox.Show("Incorrect or incomplete information about Product to Add!");
            }
            

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Database.Delete(Convert.ToInt32(dgvProducts.CurrentRow.Cells[0].Value));
            dgvProducts.DataSource = Database.GetProducts();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (Utilities.ProductValidation(tbxUpdateName.Text, tbxUpdatePrice.Text, tbxUpdateStockAmount.Text))
            {
                Database.Update(new Product
                {
                    Id = Convert.ToInt32(dgvProducts.CurrentRow.Cells[0].Value),
                    Name = tbxUpdateName.Text,
                    Price = Convert.ToDecimal(tbxUpdatePrice.Text),
                    StockAmount = Convert.ToInt32(tbxUpdateStockAmount.Text)
                }
            );
                dgvProducts.DataSource = Database.GetProducts();
            }
            else
            {
                MessageBox.Show("Incorrect or incomplete information about product to Update!");
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dgvProducts.DataSource = Database.GetProducts();

        }
        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUpdateName.Text = dgvProducts.CurrentRow.Cells[1].Value.ToString();
            tbxUpdatePrice.Text = dgvProducts.CurrentRow.Cells[2].Value.ToString();
            tbxUpdateStockAmount.Text = dgvProducts.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
