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

namespace Grifindo_Lanka_Leave_Management_System
{
    
    public partial class Employee_Registation : Form
    {
        public static string Emp_Name = "";
        public Employee_Registation()
        {
            InitializeComponent();
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            AdminMain_Form adminMain_Form = new AdminMain_Form();
            adminMain_Form.WindowState = FormWindowState.Maximized; 
            adminMain_Form.Show();
            this.Hide();
        }

        private void Registeremp_Click(object sender, EventArgs e)
        {
            //Assign the values to Variables
            string ID = Employee_id.Text;
            string Name = Employee_name.Text;
            string JoinDate = DTJoindate.Text;
            string Contact = ContactNo.Text;
            int WorkedMonth;
            string Password = txt_Password.Text;
            Emp_Name = Name;

            //Calculate the Worked Month
            DateTime Today = DateTime.Today;
            DateTime GivenDate = DTJoindate.Value;
            WorkedMonth = ((Today - GivenDate).Days) / 30;

            if (string.IsNullOrWhiteSpace(Employee_id.Text)|| string.IsNullOrWhiteSpace(Employee_name.Text) || string.IsNullOrWhiteSpace(DTJoindate.Text) || string.IsNullOrWhiteSpace(ContactNo.Text) || string.IsNullOrWhiteSpace(txt_Password.Text))
            {
                // Error Message
                MessageBox.Show("Please fill all forms");

            }
            else
            {
                 
                try
                {
                    // Call the class
                    DB_Con li = new DB_Con();
                    // Call the Connection
                    SqlConnection con = li.DB_Connection();

                    //Sql Insert command
                    SqlCommand cmd = new SqlCommand("INSERT INTO Employee (Employee_ID,Employee_Name,Join_Date,Contact_No,Worked_Months,Password) VALUES ('" + ID + "','" + Name + "','" + JoinDate + "','" + Contact + "'," + WorkedMonth + ",'" + Password + "')", con);
                    cmd.ExecuteNonQuery();
                    
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                //Leave Balance insert
                int StartAnnualLeave;
                int StartCasualLeave;
                int StartShortLeave = 2;

                if (WorkedMonth > 6)
                {
                    StartAnnualLeave = 14;
                    StartCasualLeave = 7;
                }
                else
                {
                    StartAnnualLeave = 7;
                    StartCasualLeave = 4;
                }
                try
                {
                    // Call the class
                    DB_Con li = new DB_Con();
                    // Call the Connection
                    SqlConnection con = li.DB_Connection();

                    //Sql Insert command
                    SqlCommand cmd = new SqlCommand("INSERT INTO Leave_Balance (Employee_ID,Annual_Leave,Casual_Leave,Short_Leave) VALUES ('" +ID+ "'," +StartAnnualLeave+ "," +StartCasualLeave+ "," +StartShortLeave+ ")", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registration successfull");
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure to save the changes", "Update", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                //Assign only not null values to Variables
                string ID = Employee_id.Text;
                string Name = Employee_name.Text;
                string JoinDate = DTJoindate.Text;
                string Contact = ContactNo.Text;
                string Password = txt_Password.Text;
                int WorkedMonth;
                
                //Calculate the Worked Month
                DateTime Today = DateTime.Today;
                DateTime GivenDate = DTJoindate.Value;
                WorkedMonth = ((Today - GivenDate).Days) / 30;

                try
                {
                    // Call the class
                    DB_Con li = new DB_Con();
                    // Call the Connection
                    SqlConnection con = li.DB_Connection();

                    //Sql Update command
                    SqlCommand cmd = new SqlCommand("UPDATE Employee SET Employee_Name = '" +Name+ "' ,Join_Date = '" +JoinDate+ "', Contact_No = '" +Contact+ "', Worked_Months = " +WorkedMonth+ ", Password = '" +Password+ "' WHERE Employee_ID = '" +ID+ "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update successfull");
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Changes not saved...!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to delete this data permenently", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                //Assign only not null values to Variables
                string ID = Employee_id.Text;
               
                try
                {
                    // Call the class
                    DB_Con li = new DB_Con();
                    // Call the Connection
                    SqlConnection con = li.DB_Connection();

                    //Sql Delete command
                    SqlCommand cmd = new SqlCommand("DELETE FROM Employee WHERE Employee_ID = '" + ID + "'", con);
                    int State = cmd.ExecuteNonQuery();
                    if(State >= 1)
                    {
                        //MessageBox.Show("Data deleted...!");
                    }
                    else
                    {
                        //MessageBox.Show("Invalied ID");
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                //Delete the Leave Balance table data
                try
                {
                    // Call the class
                    DB_Con li = new DB_Con();
                    // Call the Connection
                    SqlConnection con = li.DB_Connection();

                    //Sql Delete command
                    SqlCommand cmd = new SqlCommand("DELETE FROM Leave_Balance WHERE Employee_ID = '" + ID + "'", con);
                    int State = cmd.ExecuteNonQuery();
                    if (State >= 1)
                    {
                        MessageBox.Show("Data deleted...!");
                    }
                    else
                    {
                        MessageBox.Show("Invalied ID");
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
            else
            {
                MessageBox.Show("Data not deleted...!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string SearchID = Employee_id_Search.Text;

            if (string.IsNullOrWhiteSpace(Employee_id_Search.Text))
            {
                MessageBox.Show("Please Enter the valied employee ID...!");
            }
            else
            {
                try
                {
                    //Call the class
                    DB_Con li = new DB_Con();
                    //Call the connection
                    SqlConnection con = li.DB_Connection();

                    //Sql search command
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Employee WHERE Employee_ID = '" + SearchID + "'", con);
                    SqlDataReader rdr = cmd.ExecuteReader();
                    if (rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
                            Employee_id.Text = rdr["Employee_ID"].ToString();
                            Employee_name.Text = rdr["Employee_Name"].ToString();
                            DTJoindate.Text = rdr["Join_Date"].ToString();
                            ContactNo.Text = rdr["Contact_No"].ToString();
                            txt_Password.Text = rdr["Password"].ToString();

                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalied ID...!");
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void Employee_Registation_Load(object sender, EventArgs e)
        {
            
                try
                {
                    DB_Con li = new DB_Con();
                    using (SqlConnection con = li.DB_Connection())
                    {
                        SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Employee", con);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        // Check if data is being loaded into the DataTable
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("No data found in the Employee table.");
                        }

                        dataGridView1.DataSource = dt; // Bind data to DataGridView
                    }

                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            

        }

        private void R_btn_Click(object sender, EventArgs e)
        {
            Employee_Registation employee_Registation = new Employee_Registation();
            employee_Registation.WindowState = FormWindowState.Maximized;
            employee_Registation.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
