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
    public partial class Login_Form : Form
    {
        public static string ID = "";

        public Login_Form()
        {
            InitializeComponent();
        }

        private void LginBTN_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text.Trim();
            string password = txtpassword.Text;

            // Basic validation
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Admin login check
                if (username == "Admin" && password == "123")
                {
                    AdminMain_Form adminMain_Form = new AdminMain_Form();
                    adminMain_Form.WindowState = FormWindowState.Maximized;
                    adminMain_Form.Show();
                    this.Hide();
                    return;
                }

                // Regular employee login
                DB_Con li = new DB_Con();
                SqlConnection con = null;
                SqlDataReader rdr = null;

                try
                {
                    con = li.DB_Connection();
                    con.Open();

                    string query = "SELECT Employee_Name, Employee_ID FROM Employee WHERE Employee_ID = @EmployeeID AND Password = @Password";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@EmployeeID", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        rdr = cmd.ExecuteReader();

                        if (rdr.HasRows)
                        {
                            rdr.Read();
                            string employeeName = rdr["Employee_Name"].ToString();
                            string employeeId = rdr["Employee_ID"].ToString();

                            MessageBox.Show($"Hello {employeeName} welcome to our leave management system",
                                            "Login Successful",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);

                            Leave_Apply_Form leave_Apply_Form = new Leave_Apply_Form();
                            leave_Apply_Form.WindowState = FormWindowState.Maximized;
                            leave_Apply_Form.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password",
                                            "Login Failed",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                            txtpassword.Clear();
                            txtpassword.Focus();
                        }
                    }
                }
                finally
                {
                    // Properly close resources
                    rdr?.Close();
                    con?.Close();
                    con?.Dispose();
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show($"Database error: {sqlEx.Message}\nPlease check your database connection.",
                                "Database Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Login error: {ex.Message}",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
