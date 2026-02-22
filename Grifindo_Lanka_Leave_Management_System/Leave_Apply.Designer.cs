namespace Grifindo_Lanka_Leave_Management_System
{
    partial class Leave_Apply_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_TimeSet = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Apply = new System.Windows.Forms.Button();
            this.txt_TimeTo = new System.Windows.Forms.TextBox();
            this.txt_TimeFrom_mm = new System.Windows.Forms.TextBox();
            this.txt_TimeFrom_HH = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_Reson = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_LeaveType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_Approve = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_ShortLeaves = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_CasualLeaves = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_AnnualLeaves = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_Leave_No = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(645, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apply Your Leave";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.btn_TimeSet);
            this.panel1.Controls.Add(this.btn_Clear);
            this.panel1.Controls.Add(this.btn_Apply);
            this.panel1.Controls.Add(this.txt_TimeTo);
            this.panel1.Controls.Add(this.txt_TimeFrom_mm);
            this.panel1.Controls.Add(this.txt_TimeFrom_HH);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txt_Reson);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cmb_LeaveType);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dtp_Approve);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(69, 194);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 278);
            this.panel1.TabIndex = 1;
            // 
            // btn_TimeSet
            // 
            this.btn_TimeSet.Location = new System.Drawing.Point(458, 111);
            this.btn_TimeSet.Name = "btn_TimeSet";
            this.btn_TimeSet.Size = new System.Drawing.Size(115, 24);
            this.btn_TimeSet.TabIndex = 5;
            this.btn_TimeSet.Text = "Time Set";
            this.btn_TimeSet.UseVisualStyleBackColor = true;
            this.btn_TimeSet.Click += new System.EventHandler(this.btn_TimeSet_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Clear.Location = new System.Drawing.Point(405, 224);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 38);
            this.btn_Clear.TabIndex = 5;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Apply
            // 
            this.btn_Apply.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Apply.Location = new System.Drawing.Point(232, 224);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(75, 38);
            this.btn_Apply.TabIndex = 5;
            this.btn_Apply.Text = "Apply";
            this.btn_Apply.UseVisualStyleBackColor = false;
            this.btn_Apply.Click += new System.EventHandler(this.btn_Apply_Click);
            // 
            // txt_TimeTo
            // 
            this.txt_TimeTo.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimeTo.Location = new System.Drawing.Point(178, 145);
            this.txt_TimeTo.Name = "txt_TimeTo";
            this.txt_TimeTo.ReadOnly = true;
            this.txt_TimeTo.Size = new System.Drawing.Size(332, 28);
            this.txt_TimeTo.TabIndex = 4;
            // 
            // txt_TimeFrom_mm
            // 
            this.txt_TimeFrom_mm.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimeFrom_mm.Location = new System.Drawing.Point(317, 111);
            this.txt_TimeFrom_mm.Name = "txt_TimeFrom_mm";
            this.txt_TimeFrom_mm.Size = new System.Drawing.Size(109, 28);
            this.txt_TimeFrom_mm.TabIndex = 4;
            // 
            // txt_TimeFrom_HH
            // 
            this.txt_TimeFrom_HH.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimeFrom_HH.Location = new System.Drawing.Point(178, 111);
            this.txt_TimeFrom_HH.Name = "txt_TimeFrom_HH";
            this.txt_TimeFrom_HH.Size = new System.Drawing.Size(109, 28);
            this.txt_TimeFrom_HH.TabIndex = 4;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(33, 147);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 22);
            this.label13.TabIndex = 2;
            this.label13.Text = "Time To";
            this.label13.Click += new System.EventHandler(this.label7_Click);
            // 
            // txt_Reson
            // 
            this.txt_Reson.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Reson.Location = new System.Drawing.Point(178, 179);
            this.txt_Reson.Name = "txt_Reson";
            this.txt_Reson.Size = new System.Drawing.Size(332, 28);
            this.txt_Reson.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Time From";
            this.label5.Click += new System.EventHandler(this.label7_Click);
            // 
            // cmb_LeaveType
            // 
            this.cmb_LeaveType.FormattingEnabled = true;
            this.cmb_LeaveType.Items.AddRange(new object[] {
            "Annual Leave",
            "Casual Leave",
            "Short Leave"});
            this.cmb_LeaveType.Location = new System.Drawing.Point(178, 16);
            this.cmb_LeaveType.Name = "cmb_LeaveType";
            this.cmb_LeaveType.Size = new System.Drawing.Size(332, 24);
            this.cmb_LeaveType.TabIndex = 3;
            this.cmb_LeaveType.SelectedIndexChanged += new System.EventHandler(this.cmb_LeaveType_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 22);
            this.label7.TabIndex = 2;
            this.label7.Text = "Reson";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "Type";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // dtp_Approve
            // 
            this.dtp_Approve.CustomFormat = "";
            this.dtp_Approve.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Approve.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Approve.Location = new System.Drawing.Point(178, 46);
            this.dtp_Approve.Name = "dtp_Approve";
            this.dtp_Approve.Size = new System.Drawing.Size(332, 28);
            this.dtp_Approve.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(349, 82);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 22);
            this.label15.TabIndex = 0;
            this.label15.Text = "mm";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(212, 82);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 22);
            this.label14.TabIndex = 0;
            this.label14.Text = "HH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Date";
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(1008, 133);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(98, 38);
            this.btn_Delete.TabIndex = 5;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Employee ID";
            // 
            // txt_ID
            // 
            this.txt_ID.BackColor = System.Drawing.Color.White;
            this.txt_ID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID.Location = new System.Drawing.Point(205, 149);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(251, 30);
            this.txt_ID.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(83, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // txt_Name
            // 
            this.txt_Name.BackColor = System.Drawing.Color.White;
            this.txt_Name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(205, 111);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.ReadOnly = true;
            this.txt_Name.Size = new System.Drawing.Size(251, 30);
            this.txt_Name.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.txt_ShortLeaves);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txt_CasualLeaves);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.txt_AnnualLeaves);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(739, 194);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(722, 278);
            this.panel2.TabIndex = 4;
            // 
            // txt_ShortLeaves
            // 
            this.txt_ShortLeaves.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ShortLeaves.Location = new System.Drawing.Point(329, 171);
            this.txt_ShortLeaves.Name = "txt_ShortLeaves";
            this.txt_ShortLeaves.ReadOnly = true;
            this.txt_ShortLeaves.Size = new System.Drawing.Size(223, 28);
            this.txt_ShortLeaves.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(109, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(113, 22);
            this.label11.TabIndex = 1;
            this.label11.Text = "Short Leaves";
            // 
            // txt_CasualLeaves
            // 
            this.txt_CasualLeaves.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CasualLeaves.Location = new System.Drawing.Point(329, 126);
            this.txt_CasualLeaves.Name = "txt_CasualLeaves";
            this.txt_CasualLeaves.ReadOnly = true;
            this.txt_CasualLeaves.Size = new System.Drawing.Size(223, 28);
            this.txt_CasualLeaves.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(109, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 22);
            this.label10.TabIndex = 1;
            this.label10.Text = "Casual Leaves";
            // 
            // txt_AnnualLeaves
            // 
            this.txt_AnnualLeaves.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_AnnualLeaves.Location = new System.Drawing.Point(329, 80);
            this.txt_AnnualLeaves.Name = "txt_AnnualLeaves";
            this.txt_AnnualLeaves.ReadOnly = true;
            this.txt_AnnualLeaves.Size = new System.Drawing.Size(223, 28);
            this.txt_AnnualLeaves.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(109, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 22);
            this.label9.TabIndex = 1;
            this.label9.Text = "Annual Leaves";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(286, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 22);
            this.label8.TabIndex = 0;
            this.label8.Text = "Equal Leaves";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumPurple;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1517, 100);
            this.panel3.TabIndex = 5;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(1213, 133);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(97, 38);
            this.btn_Refresh.TabIndex = 5;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh1);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(28, 688);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(111, 40);
            this.btn_Back.TabIndex = 5;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(69, 522);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1392, 136);
            this.dataGridView1.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(674, 488);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 22);
            this.label12.TabIndex = 7;
            this.label12.Text = "My Leaves";
            // 
            // txt_Leave_No
            // 
            this.txt_Leave_No.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Leave_No.Location = new System.Drawing.Point(651, 147);
            this.txt_Leave_No.Name = "txt_Leave_No";
            this.txt_Leave_No.Size = new System.Drawing.Size(142, 28);
            this.txt_Leave_No.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(567, 114);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(318, 22);
            this.label16.TabIndex = 7;
            this.label16.Text = "Enter the Leave No to Cancel the leave";
            // 
            // Leave_Apply_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1517, 760);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_Leave_No);
            this.Controls.Add(this.panel3);
            this.Name = "Leave_Apply_Form";
            this.Text = "Leave_Apply";
            this.Load += new System.EventHandler(this.Leave_Apply_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.DateTimePicker dtp_Approve;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Reson;
        private System.Windows.Forms.ComboBox cmb_LeaveType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Apply;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_ShortLeaves;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_CasualLeaves;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_AnnualLeaves;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.TextBox txt_TimeTo;
        private System.Windows.Forms.TextBox txt_TimeFrom_HH;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_TimeFrom_mm;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_TimeSet;
        private System.Windows.Forms.TextBox txt_Leave_No;
        private System.Windows.Forms.Label label16;
    }
}
