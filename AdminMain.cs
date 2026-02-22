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
    public partial class AdminMain_Form : Form
    {
        public AdminMain_Form()
        {
            InitializeComponent();
            // Set to normal window state with specific size
            this.WindowState = FormWindowState.Normal;
            this.Size = new Size(1250, 800);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login_Form login_Form = new Login_Form();
            login_Form.Show();
            this.Hide();
        }

        private void Report_Click(object sender, EventArgs e)
        {
            Emp_Report_Form emp_Report_Form = new Emp_Report_Form();
            emp_Report_Form.WindowState = FormWindowState.Maximized;    
            emp_Report_Form.Show();
            this.Hide();
        }

        private void EmployeeRegister_Click(object sender, EventArgs e)
        {
            Employee_Registation employee_Registation = new Employee_Registation();
            employee_Registation.WindowState = FormWindowState.Maximized;
            employee_Registation.Show();
            this.Hide();
        }

        private void btn_Accept_Click(object sender, EventArgs e)
        {
            
            //Assign value ID
            string Type = "";
            string ID = "";
            int AnnualLeave = 0;
            int CasualLeave =0;
            int ShortLeave = 0;
            

            var Result = MessageBox.Show("Do you want to Approve this leave", "Approve", MessageBoxButtons.YesNo);
            if (Result == DialogResult.Yes)
            {
                //Get the Leave balance
                try
                {
                    

                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                //Update Leaves
                try
                {
                    //Search the Leave type
                    int LeaveNo = int.Parse(txt_No.Text);

                    DB_Con li = new DB_Con();
                    SqlConnection con = li.DB_Connection();
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Leave WHERE Leave_No = '" + LeaveNo + "'", con);
                    SqlDataReader rdr = cmd.ExecuteReader();
                    if (rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
                            Type = rdr["Leave_Type"].ToString();
                            ID = rdr["Emp_ID"].ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid leave number");
                    }
                    con.Close();

                    // Get currunt leave count
                    DB_Con li2 = new DB_Con();
                    SqlConnection con2 = li2.DB_Connection();
                    SqlCommand cmd2 = new SqlCommand("SELECT * FROM Leave_Balance WHERE Employee_ID = '" + ID + "'", con2);
                    SqlDataReader rdr2 = cmd2.ExecuteReader();
                    if (rdr2.HasRows)
                    {
                        while (rdr2.Read())
                        {
                            AnnualLeave = Convert.ToInt32(rdr2["Annual_Leave"]);
                            CasualLeave = Convert.ToInt32(rdr2["Casual_Leave"]);
                            ShortLeave = Convert.ToInt32(rdr2["Short_Leave"]);
                        }
                    }
                    con2.Close();

                    // Calculate the leaves
                    if (Type == "Annual Leave")
                    {
                        AnnualLeave = AnnualLeave - 1;
                    }
                    else if (Type == "Casual Leave")
                    {
                        CasualLeave = CasualLeave - 1;
                    }
                    else if (Type == "Short Leave")
                    {
                        ShortLeave = ShortLeave - 1;
                    }

                    //Update the leave balance
                    DB_Con li1 = new DB_Con();
                    SqlConnection con1 = li1.DB_Connection();
                    SqlCommand cmd1 = new SqlCommand("UPDATE Leave_Balance SET Annual_Leave = " +AnnualLeave+ ", Casual_Leave = " +CasualLeave+ ", Short_Leave = " +ShortLeave+ " WHERE Employee_ID = '" +ID+ "'", con1);
                    cmd1.ExecuteNonQuery();
                    con1.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                //Approve the leave

                try
                {
                    int LeaveNo = int.Parse(txt_No.Text);


                    DB_Con li = new DB_Con();
                    SqlConnection con = li.DB_Connection();
                    SqlCommand cmd = new SqlCommand("UPDATE Leave SET Status = 'Approved' WHERE Leave_No = " + LeaveNo + "", con);
                    int State = cmd.ExecuteNonQuery();
                    if(State >= 1)
                    {
                        MessageBox.Show("Leave Approved");
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
                MessageBox.Show("Leave not approved");
            }
            
        }

        private void AdminMain_Form_Load(object sender, EventArgs e)
        {
            //Show the data Pending leaves

            try
            {
                DB_Con li = new DB_Con();
                using (SqlConnection con = li.DB_Connection())
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Leave WHERE Status = 'Pending'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Check if data is being loaded into the DataTable
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No data found in the pending leaves table.");
                    }

                    dataGridView1.DataSource = dt; // Bind data to DataGridView
                }

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Show the data Approved leaves
            try
            {
                DB_Con li = new DB_Con();
                using (SqlConnection con = li.DB_Connection())
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Leave WHERE Status = 'Approved'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    //Check if Data load
                    if(dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No data found in the approved leaves table.");
                    }
                    dataGridView2.DataSource = dt; //Show the data
                }

                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.Message);
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            var Result = MessageBox.Show("Do you want to reject this leave", "Reject", MessageBoxButtons.YesNo);
            if (Result == DialogResult.Yes)
            {
                try
                {
                    int LeaveNo = int.Parse(txt_No.Text);

                    DB_Con li = new DB_Con();
                    SqlConnection con = li.DB_Connection();
                    SqlCommand cmd = new SqlCommand("UPDATE Leave SET Status = 'Rejected' WHERE Leave_No = " + LeaveNo + "", con);
                    int State = cmd.ExecuteNonQuery();
                    if(State >= 1)
                    {
                        MessageBox.Show("Leave rejected");
                    }
                    else
                    {
                        MessageBox.Show("Invalid leave number");
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
                MessageBox.Show("Leave not reject");
            }
            
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                int LeaveNo = int.Parse(txt_No.Text);
                string SearchID = "";

                DB_Con li = new DB_Con();
                SqlConnection con = li.DB_Connection();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Leave WHERE Leave_No = " +LeaveNo+ "", con);
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while(rdr.Read())
                    {
                        SearchID = rdr["Emp_ID"].ToString();
                    }
                }
                else
                {
                    lbl_Name.Text = "Name not found";
                    lbl_Contact.Text = "Contact number not found";
                }
                con.Close();

                DB_Con li1 = new DB_Con();
                SqlConnection con1 = li1.DB_Connection();
                SqlCommand cmd1 = new SqlCommand("SELECT * FROM Employee WHERE Employee_ID = '" +SearchID+ "'", con1);
                SqlDataReader rdr1 = cmd1.ExecuteReader();
                if (rdr1.HasRows)
                {
                    while (rdr1.Read())
                    {
                        lbl_Name.Text = rdr1["Employee_Name"].ToString();
                        lbl_Contact.Text = rdr1["Contact_No"].ToString();
                    }
                }
                con1.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_ShortLeave_Reset_Click(object sender, EventArgs e)
        {
            var Result = MessageBox.Show("Are you sure you want to reset the short leaves?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Result == DialogResult.Yes)
            {
                try
                {
                    DB_Con li = new DB_Con();
                    SqlConnection con = li.DB_Connection();
                    SqlCommand cmd = new SqlCommand("UPDATE Leave_Balance SET Short_Leave = " + 2 + "", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Short leaves reset...!");
                    con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Short leave not reset");
            }
            
            
        }

        private void btn_AllLeaves_Reset_Click(object sender, EventArgs e)
        {
            
            var Result = MessageBox.Show("Are you sure you want to reset the all leaves", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (Result == DialogResult.Yes)
            {
                int AnnualLeave_Permenent = 14;
                int CasualLeave_Permenent = 7;
                int AnnualLeave_Tempory = 7;
                int CasualLeave_Tempory = 4;
                int ShortLeave = 2;

                try
                {
                    DB_Con li = new DB_Con();
                    SqlConnection con = li.DB_Connection();
                    SqlTransaction tran = con.BeginTransaction();
                    try
                    {
                        //Reset Permenent members leaves
                        SqlCommand cmd = new SqlCommand("UPDATE Leave_Balance SET Annual_Leave = " + AnnualLeave_Permenent + ", Casual_Leave = " + CasualLeave_Permenent + ", Short_Leave = " + ShortLeave + " WHERE " +
                            "Employee_ID IN (SELECT Employee_ID FROM Employee WHERE Worked_Months > 6)", con, tran);
                        cmd.ExecuteNonQuery();

                        //Reset Tempory members Leaves
                        SqlCommand cmd1 = new SqlCommand("UPDATE Leave_Balance SET Annual_Leave = " + AnnualLeave_Tempory + ", Casual_Leave = " + CasualLeave_Tempory + ", Short_Leave = " + ShortLeave + " WHERE " +
                           "Employee_ID IN (SELECT Employee_ID FROM Employee WHERE Worked_Months <= 6)", con, tran);
                        cmd1.ExecuteNonQuery();

                        tran.Commit();
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        MessageBox.Show(ex.Message);
                    }

                    //Delete all data in leave table
                    try
                    {
                        DB_Con li2 = new DB_Con();
                        SqlConnection con2 = li2.DB_Connection();
                        SqlCommand cmd2 = new SqlCommand("DELETE FROM Leave", con2);
                        cmd2.ExecuteNonQuery();
                        MessageBox.Show("All leaves Reset...!");
                        con2.Close();
                    }
                    catch (Exception ex) 
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                
            }
            else 
            {
                MessageBox.Show("Leaves not reset...!");
            }

            

        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            AdminMain_Form adminMain_Form = new AdminMain_Form();
            adminMain_Form.WindowState = FormWindowState.Maximized;
            adminMain_Form.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
