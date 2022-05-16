
namespace NewDatabase
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bttnInsertStm = new System.Windows.Forms.Button();
            this.bttnReadStm = new System.Windows.Forms.Button();
            this.bttnUpdStm = new System.Windows.Forms.Button();
            this.bttnDltStm = new System.Windows.Forms.Button();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtOtherNames = new System.Windows.Forms.TextBox();
            this.txtMobileNo = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtResidAdd = new System.Windows.Forms.TextBox();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgView = new System.Windows.Forms.DataGridView();
            this.txtDEmp = new System.Windows.Forms.DateTimePicker();
            this.txtDOB = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.bttnTraineeID = new System.Windows.Forms.Label();
            this.txtTraineeID = new System.Windows.Forms.TextBox();
            this.bttnCustomRead = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnInsertStm
            // 
            this.bttnInsertStm.BackColor = System.Drawing.Color.Purple;
            this.bttnInsertStm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnInsertStm.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bttnInsertStm.Location = new System.Drawing.Point(636, 80);
            this.bttnInsertStm.Name = "bttnInsertStm";
            this.bttnInsertStm.Size = new System.Drawing.Size(209, 36);
            this.bttnInsertStm.TabIndex = 0;
            this.bttnInsertStm.Text = "Insert Records";
            this.bttnInsertStm.UseVisualStyleBackColor = false;
            this.bttnInsertStm.Click += new System.EventHandler(this.bttnInsertStm_Click);
            // 
            // bttnReadStm
            // 
            this.bttnReadStm.BackColor = System.Drawing.Color.Purple;
            this.bttnReadStm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnReadStm.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bttnReadStm.Location = new System.Drawing.Point(636, 144);
            this.bttnReadStm.Name = "bttnReadStm";
            this.bttnReadStm.Size = new System.Drawing.Size(209, 36);
            this.bttnReadStm.TabIndex = 0;
            this.bttnReadStm.Text = "Read Records";
            this.bttnReadStm.UseVisualStyleBackColor = false;
            this.bttnReadStm.Click += new System.EventHandler(this.bttnReadStm_Click);
            // 
            // bttnUpdStm
            // 
            this.bttnUpdStm.BackColor = System.Drawing.Color.Purple;
            this.bttnUpdStm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnUpdStm.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bttnUpdStm.Location = new System.Drawing.Point(636, 278);
            this.bttnUpdStm.Name = "bttnUpdStm";
            this.bttnUpdStm.Size = new System.Drawing.Size(209, 36);
            this.bttnUpdStm.TabIndex = 0;
            this.bttnUpdStm.Text = "Update Records";
            this.bttnUpdStm.UseVisualStyleBackColor = false;
            this.bttnUpdStm.Click += new System.EventHandler(this.bttnUpdStm_Click);
            // 
            // bttnDltStm
            // 
            this.bttnDltStm.BackColor = System.Drawing.Color.Purple;
            this.bttnDltStm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnDltStm.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bttnDltStm.Location = new System.Drawing.Point(636, 343);
            this.bttnDltStm.Name = "bttnDltStm";
            this.bttnDltStm.Size = new System.Drawing.Size(209, 36);
            this.bttnDltStm.TabIndex = 0;
            this.bttnDltStm.Text = "Delete Records";
            this.bttnDltStm.UseVisualStyleBackColor = false;
            this.bttnDltStm.Click += new System.EventHandler(this.bttnDltStm_Click);
            // 
            // txtSurname
            // 
            this.txtSurname.BackColor = System.Drawing.SystemColors.Info;
            this.txtSurname.Location = new System.Drawing.Point(345, 101);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(200, 19);
            this.txtSurname.TabIndex = 1;
            // 
            // txtOtherNames
            // 
            this.txtOtherNames.BackColor = System.Drawing.SystemColors.Info;
            this.txtOtherNames.Location = new System.Drawing.Point(345, 144);
            this.txtOtherNames.Name = "txtOtherNames";
            this.txtOtherNames.Size = new System.Drawing.Size(200, 19);
            this.txtOtherNames.TabIndex = 1;
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.BackColor = System.Drawing.SystemColors.Info;
            this.txtMobileNo.Location = new System.Drawing.Point(345, 229);
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(200, 19);
            this.txtMobileNo.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Info;
            this.txtEmail.Location = new System.Drawing.Point(345, 266);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 19);
            this.txtEmail.TabIndex = 1;
            // 
            // txtResidAdd
            // 
            this.txtResidAdd.BackColor = System.Drawing.SystemColors.Info;
            this.txtResidAdd.Location = new System.Drawing.Point(345, 310);
            this.txtResidAdd.Multiline = true;
            this.txtResidAdd.Name = "txtResidAdd";
            this.txtResidAdd.Size = new System.Drawing.Size(200, 34);
            this.txtResidAdd.TabIndex = 1;
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.BackColor = System.Drawing.SystemColors.Info;
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Prefer Not to Say"});
            this.comboBoxGender.Location = new System.Drawing.Point(345, 184);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(200, 21);
            this.comboBoxGender.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Purple;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(133, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Surname";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Purple;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(133, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Other Names";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Purple;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(133, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Gender";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Purple;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(133, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mobile No";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Purple;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(133, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Email Address";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Purple;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(133, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Residential Address";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Purple;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(133, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 23);
            this.label7.TabIndex = 3;
            this.label7.Text = "Date Employed";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Purple;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label8.Location = new System.Drawing.Point(133, 391);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 23);
            this.label8.TabIndex = 3;
            this.label8.Text = "Date of Birth";
            // 
            // dgView
            // 
            this.dgView.BackgroundColor = System.Drawing.Color.White;
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dgView.Location = new System.Drawing.Point(12, 434);
            this.dgView.Name = "dgView";
            this.dgView.RowHeadersWidth = 51;
            this.dgView.RowTemplate.Height = 24;
            this.dgView.Size = new System.Drawing.Size(997, 172);
            this.dgView.TabIndex = 4;
            this.dgView.SelectionChanged += new System.EventHandler(this.dgView_SelectionChanged);
            // 
            // txtDEmp
            // 
            this.txtDEmp.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.txtDEmp.CustomFormat = "dd/MM/yyyy";
            this.txtDEmp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDEmp.Location = new System.Drawing.Point(345, 350);
            this.txtDEmp.Name = "txtDEmp";
            this.txtDEmp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDEmp.Size = new System.Drawing.Size(200, 19);
            this.txtDEmp.TabIndex = 6;
            // 
            // txtDOB
            // 
            this.txtDOB.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.txtDOB.CustomFormat = "dd/MM/yyyy";
            this.txtDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtDOB.Location = new System.Drawing.Point(345, 391);
            this.txtDOB.Name = "txtDOB";
            this.txtDOB.Size = new System.Drawing.Size(200, 19);
            this.txtDOB.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.WindowText;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(40, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(956, 43);
            this.label9.TabIndex = 8;
            this.label9.Text = "Microsoft/Elev8 Software Development Cohort 4 Trainee Records";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bttnTraineeID
            // 
            this.bttnTraineeID.BackColor = System.Drawing.Color.Purple;
            this.bttnTraineeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnTraineeID.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bttnTraineeID.Location = new System.Drawing.Point(133, 63);
            this.bttnTraineeID.Name = "bttnTraineeID";
            this.bttnTraineeID.Size = new System.Drawing.Size(146, 23);
            this.bttnTraineeID.TabIndex = 3;
            this.bttnTraineeID.Text = "Trainee ID";
            // 
            // txtTraineeID
            // 
            this.txtTraineeID.BackColor = System.Drawing.SystemColors.Info;
            this.txtTraineeID.Location = new System.Drawing.Point(345, 63);
            this.txtTraineeID.Name = "txtTraineeID";
            this.txtTraineeID.Size = new System.Drawing.Size(200, 19);
            this.txtTraineeID.TabIndex = 1;
            // 
            // bttnCustomRead
            // 
            this.bttnCustomRead.BackColor = System.Drawing.Color.Purple;
            this.bttnCustomRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCustomRead.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.bttnCustomRead.Location = new System.Drawing.Point(636, 206);
            this.bttnCustomRead.Name = "bttnCustomRead";
            this.bttnCustomRead.Size = new System.Drawing.Size(209, 42);
            this.bttnCustomRead.TabIndex = 0;
            this.bttnCustomRead.Text = "Read Custom Records";
            this.bttnCustomRead.UseVisualStyleBackColor = false;
            this.bttnCustomRead.Click += new System.EventHandler(this.bttnCustomRead_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1021, 657);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDOB);
            this.Controls.Add(this.txtDEmp);
            this.Controls.Add(this.dgView);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bttnTraineeID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxGender);
            this.Controls.Add(this.txtResidAdd);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtMobileNo);
            this.Controls.Add(this.txtOtherNames);
            this.Controls.Add(this.txtTraineeID);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.bttnDltStm);
            this.Controls.Add(this.bttnUpdStm);
            this.Controls.Add(this.bttnCustomRead);
            this.Controls.Add(this.bttnReadStm);
            this.Controls.Add(this.bttnInsertStm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cohort 4 Trainee Records ";
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnInsertStm;
        private System.Windows.Forms.Button bttnReadStm;
        private System.Windows.Forms.Button bttnUpdStm;
        private System.Windows.Forms.Button bttnDltStm;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtOtherNames;
        private System.Windows.Forms.TextBox txtMobileNo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtResidAdd;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgView;
        private System.Windows.Forms.DateTimePicker txtDEmp;
        private System.Windows.Forms.DateTimePicker txtDOB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label bttnTraineeID;
        private System.Windows.Forms.TextBox txtTraineeID;
        private System.Windows.Forms.Button bttnCustomRead;
    }
}

