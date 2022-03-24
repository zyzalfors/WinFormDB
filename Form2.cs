using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace EmployeeOrder
{

    public partial class OrdersForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BM18PFE4;Initial Catalog=EmployeeOrder;Integrated Security=True");
        SqlCommand cmd = null;
        SqlParameter par = null;
        public OrdersForm(string title)
        {
            
            InitializeComponent();
            this.Text = title;
        }


    private void OnLoadOrdersForm(object sender, EventArgs e)
        {
            string title = this.Text;
            string eid = title.Substring(title.IndexOf('=') + 1);
            try
            {
                con.Open();
                cmd = new SqlCommand("select o.oid as OrderID, e.eid as EmployeeID, qty as Quantity, price as Price from employees as e inner join orders as o on e.eid = o.eid  where o.eid=@eid", con);
                par = new SqlParameter("@eid", SqlDbType.Int);
                par.SourceColumn = "@eid";
                par.IsNullable = false;
                par.Value = eid;
                cmd.Parameters.Add(par);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ordersGrid.DataSource = dt;
            }
            catch (Exception)
            {
             MessageBox.Show("Orders extraction aborted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { con.Close(); }

        }

        private void OnSaveOrders(object sender, EventArgs e)
        {
            string filePath = null;
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = saveDialog.FileName;
            }

            StreamWriter outputFile = new StreamWriter(filePath);
            outputFile.WriteLine("OrderId;EmployeeID;Quantity;Price;");
            DataGridViewRowCollection gridRows = ordersGrid.Rows; 
            foreach (DataGridViewRow row in gridRows)
            {
                string rowText = null;
                DataGridViewCellCollection cells = row.Cells;
                foreach (DataGridViewCell cell in cells)
                {
                    rowText += cell.Value.ToString() + ";";          
                }
                outputFile.WriteLine(rowText);
            }
            outputFile.Close();

        }

    }
}
            
    

