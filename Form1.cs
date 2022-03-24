using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeOrder
{
    public partial class MainForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-BM18PFE4;Initial Catalog=EmployeeOrder;Integrated Security=True");
        SqlCommand cmd = null;
        SqlParameter par = null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void updateGrid()
        {

            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(new SqlCommand("select * from dbo.employees", con));
                DataTable dt = new DataTable();
                da.Fill(dt);
                tableGrid.DataSource = dt;
            }
            catch (Exception)
            {
             MessageBox.Show("Grid update aborted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
            finally { con.Close(); }
        }

        private void OnLoad(object sender, EventArgs e)
        {
            updateGrid();   

        }

        private void OnSaveClick(object sender, EventArgs e)
        {
            string eid = IDText.Text;
            string name = nameText.Text;
            string salary = salaryText.Text;
            string city = cityText.Text;
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(salary) || string.IsNullOrEmpty(city))
            {
              MessageBox.Show("Some values among Employee Name, Employee Salary, Employee City are empty. Enter valid values", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
             try
                {
                    
                    cmd = new SqlCommand("Insert into dbo.employees (name,salary,city) values (@name,@salary,@city)", con);
                    par = new SqlParameter("@name", SqlDbType.VarChar, 50);
                    par.SourceColumn = "@name";
                    par.IsNullable = false;
                    par.Value = name;
                    cmd.Parameters.Add(par);

                    par = new SqlParameter("@salary", SqlDbType.Float);
                    par.SourceColumn = "salary";
                    par.IsNullable = false;
                    par.Value = salary;
                    cmd.Parameters.Add(par);

                    par = new SqlParameter("@city", SqlDbType.VarChar, 100);
                    par.SourceColumn = "city";
                    par.IsNullable = false;
                    par.Value = city;
                    cmd.Parameters.Add(par);

                    con.Open();
                    cmd.ExecuteReader();              
                    }
                 catch (Exception)
                 {
                  MessageBox.Show("Save aborted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
                finally
                {
                    con.Close();
                    updateGrid();
                }
            }

        }

        private void OnFindClick(object sender, EventArgs e)
        {
            string eid = IDText.Text;
            SqlDataReader dr = null;
            if (string.IsNullOrEmpty(eid))
            {
                MessageBox.Show("Employee ID is empty. Enter a valid value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {

                    cmd = new SqlCommand("select * from dbo.employees where eid = @eid", con);
                    par = new SqlParameter("@eid", SqlDbType.Int);
                    par.SourceColumn = "@eid";
                    par.IsNullable = false;
                    par.Value = eid;
                    cmd.Parameters.Add(par);
                    con.Open();
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                     nameText.Text = dr.GetValue(1).ToString();
                     cityText.Text = dr.GetValue(3).ToString();
                     salaryText.Text = dr.GetDouble(2).ToString();
                    }
                    else
                    {
                      MessageBox.Show("No result found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Search aborted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    dr.Close();
                    con.Close();
                }

            }


        }

        private void OnUpdateClick(object sender, EventArgs e)
        {
            string eid = IDText.Text;
            string name = nameText.Text;
            string salary = salaryText.Text;
            string city = cityText.Text;

            try
            {
                    cmd = new SqlCommand("update employees set name=@name,salary=@salary,city=@city where eid=@eid", con);
                    par = new SqlParameter("@eid", SqlDbType.Int);
                    par.SourceColumn = "@eid";
                    par.IsNullable = false;
                    par.Value = eid;
                    cmd.Parameters.Add(par);

                    par = new SqlParameter("@name", SqlDbType.VarChar, 50);
                    par.SourceColumn = "@name";
                    par.IsNullable = false;
                    par.Value = name;
                    cmd.Parameters.Add(par);

                    par = new SqlParameter("@salary", SqlDbType.Float);
                    par.SourceColumn = "salary";
                    par.IsNullable = false;
                    par.Value = salary;
                    cmd.Parameters.Add(par);

                    par = new SqlParameter("@city", SqlDbType.VarChar, 100);
                    par.SourceColumn = "city";
                    par.IsNullable = false;
                    par.Value = city;
                    cmd.Parameters.Add(par);

                    con.Open();
                    cmd.ExecuteReader();

                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Update aborted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                   con.Close();
                   updateGrid();
            }

            
        }

        private void OnDeleteClick(object sender, EventArgs e)
        {
            string eid = IDText.Text;
            if (string.IsNullOrEmpty(eid))
            {
                MessageBox.Show("Employee ID is empty. Enter a valid value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {

                    cmd = new SqlCommand("delete from dbo.employees where eid = @eid", con);
                    par = new SqlParameter("@eid", SqlDbType.Int);
                    par.SourceColumn = "@eid";
                    par.IsNullable = false;
                    par.Value = eid;
                    cmd.Parameters.Add(par);
                    con.Open();
                    cmd.ExecuteReader();
                   

                }
                catch (Exception)
                {
                    MessageBox.Show("Search aborted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                    updateGrid();
                }

            }

        }

        private void OnLoadOrders(object sender, EventArgs e)
        {


            string eid = IDText.Text;
            OrdersForm of = new OrdersForm("Orders of eid="+eid);
            of.Show();
        }
    }
}