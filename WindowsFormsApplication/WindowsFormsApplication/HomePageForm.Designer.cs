namespace WindowsFormsApplication
{
    partial class HomePageForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboBoxDepartMent = new System.Windows.Forms.ComboBox();
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboBoxDepartMent);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtBoxLastName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBoxFirstName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBoxStudentId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 172);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Info";
            // 
            // cboBoxDepartMent
            // 
            this.cboBoxDepartMent.Enabled = false;
            this.cboBoxDepartMent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBoxDepartMent.FormattingEnabled = true;
            this.cboBoxDepartMent.Location = new System.Drawing.Point(116, 131);
            this.cboBoxDepartMent.Name = "cboBoxDepartMent";
            this.cboBoxDepartMent.Size = new System.Drawing.Size(121, 24);
            this.cboBoxDepartMent.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioBtnPartTime);
            this.groupBox2.Controls.Add(this.radioBtnFullTime);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.radioBtnPartTime.TabStop = true;
            this.radioBtnPartTime.Text = "Part Time";
            this.radioBtnPartTime.UseVisualStyleBackColor = true;
            // 
            // radioBtnFullTime
            // 
            this.radioBtnFullTime.AutoSize = true;
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
            this.txtBoxLastName.Size = new System.Drawing.Size(121, 22);
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
            this.txtBoxFirstName.Size = new System.Drawing.Size(121, 22);
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
            this.txtBoxStudentId.Size = new System.Drawing.Size(121, 22);
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(590, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "New Student";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(590, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "Remove Student";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(590, 154);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(127, 42);
            this.button3.TabIndex = 1;
            this.button3.Text = "Edit Student";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 228);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(549, 230);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // HomePageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(733, 494);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "HomePageForm";
            this.Text = "Student Registration Main Window";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioBtnPartTime;
        private System.Windows.Forms.RadioButton radioBtnFullTime;
        private System.Windows.Forms.TextBox txtBoxStudentId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboBoxDepartMent;
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}