namespace WindowsFormsApplication
{
    partial class RemoveStudentForm
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboBoxDepartment = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioBtnPartTime = new System.Windows.Forms.RadioButton();
            this.radioBtnFullTime = new System.Windows.Forms.RadioButton();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxStudentId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(461, 239);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(127, 42);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "CANCLE";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(306, 239);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(127, 42);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "REMOVE";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboBoxDepartment);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtBoxLastName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBoxFirstName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBoxStudentId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(34, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 172);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Info";
            // 
            // cboBoxDepartment
            // 
            this.cboBoxDepartment.Enabled = false;
            this.cboBoxDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBoxDepartment.FormattingEnabled = true;
            this.cboBoxDepartment.Items.AddRange(new object[] {
            "Information Systems",
            "International Affairs",
            "Nursing",
            "Pharmacy",
            "Professional Studies",
            "Psychology",
            "Public Administration"});
            this.cboBoxDepartment.Location = new System.Drawing.Point(116, 131);
            this.cboBoxDepartment.Name = "cboBoxDepartment";
            this.cboBoxDepartment.Size = new System.Drawing.Size(140, 24);
            this.cboBoxDepartment.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioBtnPartTime);
            this.groupBox2.Controls.Add(this.radioBtnFullTime);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(293, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(244, 89);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Enrollment Type";
            // 
            // radioBtnPartTime
            // 
            this.radioBtnPartTime.AutoSize = true;
            this.radioBtnPartTime.Enabled = false;
            this.radioBtnPartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnPartTime.Location = new System.Drawing.Point(139, 44);
            this.radioBtnPartTime.Name = "radioBtnPartTime";
            this.radioBtnPartTime.Size = new System.Drawing.Size(90, 22);
            this.radioBtnPartTime.TabIndex = 1;
            this.radioBtnPartTime.Text = "Part Time";
            this.radioBtnPartTime.UseVisualStyleBackColor = true;
            // 
            // radioBtnFullTime
            // 
            this.radioBtnFullTime.AutoSize = true;
            this.radioBtnFullTime.Checked = true;
            this.radioBtnFullTime.Enabled = false;
            this.radioBtnFullTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnFullTime.Location = new System.Drawing.Point(27, 44);
            this.radioBtnFullTime.Name = "radioBtnFullTime";
            this.radioBtnFullTime.Size = new System.Drawing.Size(87, 22);
            this.radioBtnFullTime.TabIndex = 0;
            this.radioBtnFullTime.TabStop = true;
            this.radioBtnFullTime.Text = "Full-Time";
            this.radioBtnFullTime.UseVisualStyleBackColor = true;
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Enabled = false;
            this.txtBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLastName.Location = new System.Drawing.Point(116, 95);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(140, 22);
            this.txtBoxLastName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Department";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Last Name";
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Enabled = false;
            this.txtBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFirstName.Location = new System.Drawing.Point(116, 64);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(140, 22);
            this.txtBoxFirstName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Name";
            // 
            // txtBoxStudentId
            // 
            this.txtBoxStudentId.Enabled = false;
            this.txtBoxStudentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxStudentId.Location = new System.Drawing.Point(116, 33);
            this.txtBoxStudentId.Name = "txtBoxStudentId";
            this.txtBoxStudentId.Size = new System.Drawing.Size(140, 22);
            this.txtBoxStudentId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID";
            // 
            // RemoveStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 412);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RemoveStudentForm";
            this.Text = "Remove Student Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboBoxDepartment;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioBtnPartTime;
        private System.Windows.Forms.RadioButton radioBtnFullTime;
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxStudentId;
        private System.Windows.Forms.Label label1;
    }
}