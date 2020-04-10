namespace PayrollManagementSystem
{
    partial class AddEmployee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployee));
            this.txtEmployeeID = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.RadiobtnFemale = new System.Windows.Forms.RadioButton();
            this.RadiobtnMale = new System.Windows.Forms.RadioButton();
            this.dtpDateOfJoin = new System.Windows.Forms.DateTimePicker();
            this.DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txtAddress = new System.Windows.Forms.RichTextBox();
            this.txtQualification = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbxDepartement = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDesignation = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtEmployeeID
            // 
            this.txtEmployeeID.Location = new System.Drawing.Point(142, 24);
            this.txtEmployeeID.Name = "txtEmployeeID";
            this.txtEmployeeID.Size = new System.Drawing.Size(76, 20);
            this.txtEmployeeID.TabIndex = 50;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(50, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 16);
            this.label14.TabIndex = 49;
            this.label14.Text = "Employee ID";
            // 
            // RadiobtnFemale
            // 
            this.RadiobtnFemale.AutoSize = true;
            this.RadiobtnFemale.Location = new System.Drawing.Point(212, 141);
            this.RadiobtnFemale.Name = "RadiobtnFemale";
            this.RadiobtnFemale.Size = new System.Drawing.Size(31, 17);
            this.RadiobtnFemale.TabIndex = 48;
            this.RadiobtnFemale.TabStop = true;
            this.RadiobtnFemale.Text = "F";
            this.RadiobtnFemale.UseVisualStyleBackColor = true;
            // 
            // RadiobtnMale
            // 
            this.RadiobtnMale.AutoSize = true;
            this.RadiobtnMale.Location = new System.Drawing.Point(150, 141);
            this.RadiobtnMale.Name = "RadiobtnMale";
            this.RadiobtnMale.Size = new System.Drawing.Size(34, 17);
            this.RadiobtnMale.TabIndex = 47;
            this.RadiobtnMale.TabStop = true;
            this.RadiobtnMale.Text = "M";
            this.RadiobtnMale.UseVisualStyleBackColor = true;
            // 
            // dtpDateOfJoin
            // 
            this.dtpDateOfJoin.Location = new System.Drawing.Point(141, 245);
            this.dtpDateOfJoin.Name = "dtpDateOfJoin";
            this.dtpDateOfJoin.Size = new System.Drawing.Size(113, 20);
            this.dtpDateOfJoin.TabIndex = 46;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.Location = new System.Drawing.Point(437, 147);
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Size = new System.Drawing.Size(120, 20);
            this.DateOfBirth.TabIndex = 45;
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Location = new System.Drawing.Point(436, 235);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(223, 41);
            this.txtAddress.TabIndex = 44;
            this.txtAddress.Text = "";
            // 
            // txtQualification
            // 
            this.txtQualification.Location = new System.Drawing.Point(436, 181);
            this.txtQualification.Name = "txtQualification";
            this.txtQualification.Size = new System.Drawing.Size(121, 20);
            this.txtQualification.TabIndex = 43;
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(141, 208);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(115, 20);
            this.txtContact.TabIndex = 40;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(141, 170);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(115, 20);
            this.txtEmail.TabIndex = 39;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(141, 99);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(115, 20);
            this.txtLastName.TabIndex = 38;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(141, 61);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(115, 20);
            this.txtFirstName.TabIndex = 37;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(312, 185);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 16);
            this.label13.TabIndex = 36;
            this.label13.Text = "Qualification";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(311, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 16);
            this.label12.TabIndex = 35;
            this.label12.Text = "Date Of Birth";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(311, 236);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 16);
            this.label11.TabIndex = 34;
            this.label11.Text = "Address";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(311, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 32;
            this.label9.Text = "Destination";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(50, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 16);
            this.label8.TabIndex = 31;
            this.label8.Text = "Date Of Join";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(48, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "Contact";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "First Name";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(683, 274);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(122, 38);
            this.btnAdd.TabIndex = 51;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbxDepartement
            // 
            this.cmbxDepartement.FormattingEnabled = true;
            this.cmbxDepartement.Location = new System.Drawing.Point(436, 103);
            this.cmbxDepartement.Name = "cmbxDepartement";
            this.cmbxDepartement.Size = new System.Drawing.Size(121, 21);
            this.cmbxDepartement.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 53;
            this.label1.Text = "Departement";
            // 
            // txtDesignation
            // 
            this.txtDesignation.FormattingEnabled = true;
            this.txtDesignation.Location = new System.Drawing.Point(438, 56);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(119, 21);
            this.txtDesignation.TabIndex = 54;
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtDesignation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbxDepartement);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtEmployeeID);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.RadiobtnFemale);
            this.Controls.Add(this.RadiobtnMale);
            this.Controls.Add(this.dtpDateOfJoin);
            this.Controls.Add(this.DateOfBirth);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtQualification);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "AddEmployee";
            this.Size = new System.Drawing.Size(834, 330);
            this.Load += new System.EventHandler(this.AddEmployee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmployeeID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RadioButton RadiobtnFemale;
        private System.Windows.Forms.RadioButton RadiobtnMale;
        private System.Windows.Forms.DateTimePicker dtpDateOfJoin;
        private System.Windows.Forms.DateTimePicker DateOfBirth;
        private System.Windows.Forms.RichTextBox txtAddress;
        private System.Windows.Forms.TextBox txtQualification;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbxDepartement;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtDesignation;
    }
}
