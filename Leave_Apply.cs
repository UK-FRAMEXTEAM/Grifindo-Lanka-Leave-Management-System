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
    public partial class Leave_Apply_Form : Form
    {
        public Leave_Apply_Form()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Leave_Apply_Form_Load(object sender, EventArgs e)
        {
            //Load the ID
            string ID = Login_Form.ID;
            txt_ID.Text = ID.ToString();

            
            try
            {
                //Load the Name
                DB_Con li = new DB_Con();
                SqlConnection con = li.DB_Connection();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Employee WHERE Employee_ID = '" + ID + "'", con);
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        txt_Name.Text = rdr["Employee_Name"].ToString();
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Display the leaves
            try
            {
                DB_Con li = new DB_Con();
                SqlConnection con = li.DB_Connection();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Leave_Balance WHERE Employee_ID = '" +ID+ "'", con);
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    while (rdr.Read())
                    {
                        txt_AnnualLeaves.Text = rdr["Annual_Leave"].ToString();
                        txt_CasualLeaves.Text = rdr["Casual_Leave"].ToString();
                        txt_ShortLeaves.Text = rdr["Short_Leave"].ToString();
                    }
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //Display Data grid view
            try
            {
                DB_Con li = new DB_Con();
                using (SqlConnection con = li.DB_Connection())
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Leave WHERE Emp_ID = '" +ID+ "'", con);
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

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            cmb_LeaveType.Text = "";
            dtp_Approve.Value = DateTime.Today;
            txt_TimeFrom_HH.Clear();
            txt_TimeFrom_mm.Clear();
            txt_TimeTo.Clear();
            txt_Reson.Clear();

        }

        private void cmb_LeaveType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_LeaveType.SelectedItem.ToString() == "Short Leave")
            {
                txt_TimeFrom_HH.Enabled = true;
                txt_TimeFrom_mm.Enabled = true;
                txt_TimeTo.Enabled = true;
            }
            else
            {
                txt_TimeFrom_HH.Enabled=false;
                txt_TimeFrom_mm.Enabled=false;
                txt_TimeTo.Enabled=false;
            }
        }

        private void btn_Apply_Click(object sender, EventArgs e)
        {
            //Assign the values to the variables
            string ID = txt_ID.Text;
            string Name = txt_Name.Text;
            string Type = cmb_LeaveType.Text;
            DateTime LeaveDate = dtp_Approve.Value;
            DateTime? LeaveFrom = null;
            DateTime? LeaveTo = null;
            string Reson = txt_Reson.Text;
            try
            {
                if (Type == "Short Leave")
                {
                    // Parsing hour and minute for Short Leave
                    string LeaveFromHH = txt_TimeFrom_HH.Text;
                    string LeaveFrommm = txt_TimeFrom_mm.Text;

                    if (!string.IsNullOrWhiteSpace(LeaveFromHH) && !string.IsNullOrWhiteSpace(LeaveFrommm))
                    {
                        LeaveFrom = DateTime.Parse($"{LeaveDate.ToShortDateString()} {LeaveFromHH}:{LeaveFrommm}");
                    }
                    else
                    {
                        MessageBox.Show("Please enter the start time for Short Leave.");
                        return;
                    }

                    // Parsing end time for Short Leave
                    LeaveTo = DateTime.Parse($"{LeaveDate.ToShortDateString()} {txt_TimeTo.Text}");
                }
                else
                {
                    // For Annual Leave and Casual Leave, we only use the date
                    LeaveFrom = LeaveDate;
                    LeaveTo = LeaveDate; // or you can adjust LeaveTo as per your requirement for non-short leaves
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (string.IsNullOrWhiteSpace(Type))
            {
                MessageBox.Show("Please fill the all forms");
            }
            else
            {
                try
                {
                    //Leaves over or available calculate
                    bool IsLeaveAvailable = true;
                    if (Type == "Annual Leave")
                    {
                        if (Int32.Parse(txt_AnnualLeaves.Text) >= 1)
                        {
                            //Calculate date count 7
                            DateTime LDate = dtp_Approve.Value.Date;
                            DateTime CurruntDate = DateTime.Now.Date;
                            double Difference = (LDate - CurruntDate).TotalDays;
                            if (Difference >= 7)
                            {
                                IsLeaveAvailable = true;
                                
                            }
                            else
                            {
                                IsLeaveAvailable = false;
                                MessageBox.Show("Annual leaves should be applied before 7 days");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Your Annual leaves over...!");
                        }
                    }
                    else if (Type == "Casual Leave")
                    {
                        if (Int32.Parse(txt_CasualLeaves.Text) >= 1)
                        {
                            IsLeaveAvailable = true;
                            
                        }
                        else
                        {
                            IsLeaveAvailable= false;
                            MessageBox.Show("Your Casual leaves over...!");
                        }
                    }
                    else if(Type == "Short Leave")
                    {
                        
                        
                        if (Int32.Parse(txt_ShortLeaves.Text) >= 1)
                        {
                            IsLeaveAvailable = true;
                            
                        }
                        else
                        {
                            IsLeaveAvailable = false;
                            MessageBox.Show("Your Short leaves over...!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalied leave type...!");
                    }

                    //Insert new leave count and leave details
                    if (IsLeaveAvailable == true)
                    {
                        
                        //Add new leave details
                        DB_Con li2 = new DB_Con();
                        SqlConnection con2 = li2.DB_Connection();
                        SqlCommand cmd2 = new SqlCommand("INSERT INTO Leave (Emp_ID,Leave_Type,Leave_Date,Leave_From,Leave_To,Reson,Status) VALUES " +
                            "('" +ID+ "','" +Type+ "','" +LeaveDate+ "','" +LeaveFrom+ "','" +LeaveTo+ "','" +Reson+ "','Pending')", con2);
                        cmd2.ExecuteNonQuery();
                        MessageBox.Show("Sending your requirement");
                        con2.Close(); 

                        


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }

        private void btn_TimeSet_Click(object sender, EventArgs e)
        {
            try
            {
                string LeaveDate = dtp_Approve.Value.ToString("yyyy-MM-dd");
                string FromTimeHH = txt_TimeFrom_HH.Text;
                string FromTimemm = txt_TimeFrom_mm.Text;
                DateTime StartTime = DateTime.Parse(LeaveDate + " " + FromTimeHH + ":" + FromTimemm); //Currunt time

                //Define the time to add: 1 hours and 30 minutes
                TimeSpan TimeToAdd = new TimeSpan(1, 30, 0);

                //Add 1 hours and 30 minutes to the start time
                DateTime EndTime = StartTime.Add(TimeToAdd);
                txt_TimeTo.Text = EndTime.ToString("HH:mm");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void btn_Refresh1(object sender, EventArgs e)
        {
            Leave_Apply_Form leave_Apply_Form = new Leave_Apply_Form();
            leave_Apply_Form.WindowState = FormWindowState.Maximized;
            leave_Apply_Form.Show();
            this.Hide();
        }

        private void btn_Back1(object sender, EventArgs e)
        {
            Login_Form login_Form = new Login_Form();
            login_Form.Show();
            this.Hide();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            
            
            string ID = txt_ID.Text;
            // Delete the leave
            try
            {
                //Get the Leave No
                int LeaveNo = int.Parse(txt_Leave_No.Text);

                var Result = MessageBox.Show("Do you want to cancel this leave", "Delete", MessageBoxButtons.YesNo);
                if (Result == DialogResult.Yes)
                {
                    DB_Con li = new DB_Con();
                    SqlConnection con = li.DB_Connection();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Leave WHERE Leave_No = " + LeaveNo + " AND Emp_ID = '" + ID + "' AND Status = 'Pending'", con);
                    int RowsEffected = cmd.ExecuteNonQuery();
                    if (RowsEffected > 0)
                    {
                        MessageBox.Show("Leave request deleted");
                    }
                    else
                    {
                        MessageBox.Show("You can't delete your leave");
                    }
                    con.Close();
                    
                }
                else
                {
                    MessageBox.Show("Leave not deleted");
                }
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
