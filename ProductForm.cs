using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace PayrollV1
{
    public partial class ProductForm : Form
    {
        
        public ProductForm()
        {
            InitializeComponent();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {

        }

        private void InsertBTN_Click(object sender, EventArgs e)
        {
            string insertText = " insert into Products values (@amnt,@p_name,@qt) ";
            decimal.TryParse(amount.Text, out decimal amt);
            string pName= product.Text;
            int.TryParse(qty.Text, out int quant);
            int result = 0;
            using(SqlConnection conn = DBConnection.getConnection())
            {
               result=  conn.Execute(insertText, new { @amnt= amt , @p_name=pName, @qt=quant });
                //Wether object or anonymous object
              
            }
            if (result != 0) {
                updateDfv();
            }
        }
        private void updateDfv() {

            using (SqlConnection conn = DBConnection.getConnection()) {
                string query = "SELECT * FROM Products";
               IEnumerable<Products> pList= conn.Query<Products>(query);
                dataGridView1.DataSource = pList.ToList();
            }
           
        }

        private void findAllBTN_Click(object sender, EventArgs e)
        {
            updateDfv();
        }

        private void find_by_ID_Click(object sender, EventArgs e)
        {
            int.TryParse(id_field.Text, out int id);
            using (SqlConnection conn = DBConnection.getConnection())
            {
                string query = "Select * from Products where Product_ID= @id";
                List<Products> p = conn.Query<Products>(query, new { @id = id }).ToList();
                if (p != null)
                {
                   id_field.Text= p[0]?.Product_ID.ToString();
                    amount.Text= p[0]?.Amount.ToString();
                    product.Text= p[0]?.Prod_name.ToString();
                    qty.Text = p[0]?.Quantity.ToString();

                    dataGridView1.DataSource = p;
                    
                
                }
            }
        }

        private void UpdateBTN_Click(object sender, EventArgs e)
        {
            int result=0;
            using (SqlConnection conn = DBConnection.getConnection()) {

                int.TryParse(id_field.Text, out int id);
                decimal.TryParse(amount.Text, out decimal amt);
                string product_name = product.Text;
                int.TryParse(qty.Text, out int quantity);
                var obj= new  {
                amt= amt,
                p_name= product_name,
                qty=quantity,
                pID= id,
                };
                string sqlText = "update Products set Amount = @amt, Prod_name = @p_name, Quantity= @qty where Product_ID =@pID";
                result= conn.Execute(sqlText,obj);

                MessageBox.Show("" + result);
            }
            if(result > 0)
            {
                updateDfv();
            }
        }
    }
    class Products { 
    
    public int Product_ID { get; set; } 
    public decimal Amount { get; set; } 
    public string Prod_name { get; set; }
    public int Quantity { get; set; }
    
    }
}
