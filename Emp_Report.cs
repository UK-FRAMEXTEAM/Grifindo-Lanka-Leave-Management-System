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
    public partial class Emp_Report_Form : Form
    {
        public Emp_Report_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminMain_Form adminMain_Form = new AdminMain_Form();
            adminMain_Form.WindowState = FormWindowState.Maximized;
            adminMain_Form.Show();
            this.Hide();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                string Date = dtp_Date.Value.ToString("yyyy-MM-dd");

                DB_Con li = new DB_Con();
                using (SqlConnection con = li.DB_Connection())
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Leave WHERE Leave_Date = '" +Date+ "' AND Status = 'Approved'", con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridView1.DataSource = dt; // Bind data to DataGridView
                }

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
