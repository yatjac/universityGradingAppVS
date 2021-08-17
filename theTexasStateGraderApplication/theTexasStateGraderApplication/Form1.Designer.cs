namespace theTexasStateGraderApplication
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
            this.labelGraderID = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.txtBoxGraderId = new System.Windows.Forms.TextBox();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.labelGraderType = new System.Windows.Forms.Label();
            this.labelHourlyPay = new System.Windows.Forms.Label();
            this.labelHours = new System.Windows.Forms.Label();
            this.labelStipend = new System.Windows.Forms.Label();
            this.labelPayments = new System.Windows.Forms.Label();
            this.txtBoxHourlyPay = new System.Windows.Forms.TextBox();
            this.txtBoxHours = new System.Windows.Forms.TextBox();
            this.txtBoxStipend = new System.Windows.Forms.TextBox();
            this.txtBoxPayment = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvGraders = new System.Windows.Forms.DataGridView();
            this.txtBoxDepartment = new System.Windows.Forms.TextBox();
            this.txtBoxGraderType = new System.Windows.Forms.TextBox();
            this.labelGraderType1 = new System.Windows.Forms.Label();
            this.cbxGraderType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGraders)).BeginInit();
            this.SuspendLayout();
            // 
            // labelGraderID
            // 
            this.labelGraderID.AutoSize = true;
            this.labelGraderID.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGraderID.Location = new System.Drawing.Point(48, 505);
            this.labelGraderID.Name = "labelGraderID";
            this.labelGraderID.Size = new System.Drawing.Size(95, 21);
            this.labelGraderID.TabIndex = 0;
            this.labelGraderID.Text = "Grader ID:";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.Location = new System.Drawing.Point(48, 550);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(105, 21);
            this.labelFirstName.TabIndex = 1;
            this.labelFirstName.Text = "First Name:";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.Location = new System.Drawing.Point(48, 594);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(102, 21);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "Last Name:";
            // 
            // labelDepartment
            // 
            this.labelDepartment.AutoSize = true;
            this.labelDepartment.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDepartment.Location = new System.Drawing.Point(48, 640);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(112, 21);
            this.labelDepartment.TabIndex = 3;
            this.labelDepartment.Text = "Department:";
            // 
            // txtBoxGraderId
            // 
            this.txtBoxGraderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxGraderId.Location = new System.Drawing.Point(168, 497);
            this.txtBoxGraderId.Name = "txtBoxGraderId";
            this.txtBoxGraderId.ReadOnly = true;
            this.txtBoxGraderId.Size = new System.Drawing.Size(100, 28);
            this.txtBoxGraderId.TabIndex = 4;
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFirstName.Location = new System.Drawing.Point(168, 542);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.ReadOnly = true;
            this.txtBoxFirstName.Size = new System.Drawing.Size(100, 28);
            this.txtBoxFirstName.TabIndex = 5;
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLastName.Location = new System.Drawing.Point(168, 586);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.ReadOnly = true;
            this.txtBoxLastName.Size = new System.Drawing.Size(100, 28);
            this.txtBoxLastName.TabIndex = 6;
            // 
            // labelGraderType
            // 
            this.labelGraderType.AutoSize = true;
            this.labelGraderType.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGraderType.Location = new System.Drawing.Point(341, 501);
            this.labelGraderType.Name = "labelGraderType";
            this.labelGraderType.Size = new System.Drawing.Size(375, 21);
            this.labelGraderType.TabIndex = 8;
            this.labelGraderType.Text = "Grader Type (0: Undergraduate, 1: Graduate):";
            // 
            // labelHourlyPay
            // 
            this.labelHourlyPay.AutoSize = true;
            this.labelHourlyPay.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHourlyPay.Location = new System.Drawing.Point(341, 550);
            this.labelHourlyPay.Name = "labelHourlyPay";
            this.labelHourlyPay.Size = new System.Drawing.Size(106, 21);
            this.labelHourlyPay.TabIndex = 9;
            this.labelHourlyPay.Text = "Hourly Pay:";
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHours.Location = new System.Drawing.Point(341, 586);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(67, 21);
            this.labelHours.TabIndex = 10;
            this.labelHours.Text = "Hours:";
            // 
            // labelStipend
            // 
            this.labelStipend.AutoSize = true;
            this.labelStipend.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStipend.Location = new System.Drawing.Point(341, 629);
            this.labelStipend.Name = "labelStipend";
            this.labelStipend.Size = new System.Drawing.Size(77, 21);
            this.labelStipend.TabIndex = 11;
            this.labelStipend.Text = "Stipend:";
            // 
            // labelPayments
            // 
            this.labelPayments.AutoSize = true;
            this.labelPayments.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPayments.Location = new System.Drawing.Point(341, 675);
            this.labelPayments.Name = "labelPayments";
            this.labelPayments.Size = new System.Drawing.Size(95, 21);
            this.labelPayments.TabIndex = 12;
            this.labelPayments.Text = "Payments:";
            // 
            // txtBoxHourlyPay
            // 
            this.txtBoxHourlyPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxHourlyPay.Location = new System.Drawing.Point(453, 543);
            this.txtBoxHourlyPay.Name = "txtBoxHourlyPay";
            this.txtBoxHourlyPay.ReadOnly = true;
            this.txtBoxHourlyPay.Size = new System.Drawing.Size(100, 28);
            this.txtBoxHourlyPay.TabIndex = 14;
            // 
            // txtBoxHours
            // 
            this.txtBoxHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxHours.Location = new System.Drawing.Point(453, 587);
            this.txtBoxHours.Name = "txtBoxHours";
            this.txtBoxHours.ReadOnly = true;
            this.txtBoxHours.Size = new System.Drawing.Size(100, 28);
            this.txtBoxHours.TabIndex = 15;
            // 
            // txtBoxStipend
            // 
            this.txtBoxStipend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxStipend.Location = new System.Drawing.Point(453, 629);
            this.txtBoxStipend.Name = "txtBoxStipend";
            this.txtBoxStipend.ReadOnly = true;
            this.txtBoxStipend.Size = new System.Drawing.Size(100, 28);
            this.txtBoxStipend.TabIndex = 16;
            // 
            // txtBoxPayment
            // 
            this.txtBoxPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxPayment.Location = new System.Drawing.Point(453, 671);
            this.txtBoxPayment.Name = "txtBoxPayment";
            this.txtBoxPayment.ReadOnly = true;
            this.txtBoxPayment.Size = new System.Drawing.Size(100, 28);
            this.txtBoxPayment.TabIndex = 17;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(49, 736);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 35);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(218, 736);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(105, 35);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(407, 736);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 35);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvGraders
            // 
            this.dgvGraders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGraders.Location = new System.Drawing.Point(34, 12);
            this.dgvGraders.Name = "dgvGraders";
            this.dgvGraders.RowTemplate.Height = 28;
            this.dgvGraders.Size = new System.Drawing.Size(818, 455);
            this.dgvGraders.TabIndex = 21;
            this.dgvGraders.SelectionChanged += new System.EventHandler(this.dgvGraders_SelectionChanged);
            // 
            // txtBoxDepartment
            // 
            this.txtBoxDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDepartment.Location = new System.Drawing.Point(168, 635);
            this.txtBoxDepartment.Name = "txtBoxDepartment";
            this.txtBoxDepartment.ReadOnly = true;
            this.txtBoxDepartment.Size = new System.Drawing.Size(100, 28);
            this.txtBoxDepartment.TabIndex = 25;
            // 
            // txtBoxGraderType
            // 
            this.txtBoxGraderType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxGraderType.Location = new System.Drawing.Point(752, 494);
            this.txtBoxGraderType.Name = "txtBoxGraderType";
            this.txtBoxGraderType.ReadOnly = true;
            this.txtBoxGraderType.Size = new System.Drawing.Size(100, 28);
            this.txtBoxGraderType.TabIndex = 26;
            // 
            // labelGraderType1
            // 
            this.labelGraderType1.AutoSize = true;
            this.labelGraderType1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGraderType1.Location = new System.Drawing.Point(878, 29);
            this.labelGraderType1.Name = "labelGraderType1";
            this.labelGraderType1.Size = new System.Drawing.Size(273, 42);
            this.labelGraderType1.TabIndex = 27;
            this.labelGraderType1.Text = "Grader Type \r\n(0: Undergraduate, 1: Graduate):";
            // 
            // cbxGraderType
            // 
            this.cbxGraderType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGraderType.FormattingEnabled = true;
            this.cbxGraderType.Items.AddRange(new object[] {
            "All",
            "0",
            "1"});
            this.cbxGraderType.Location = new System.Drawing.Point(882, 89);
            this.cbxGraderType.Name = "cbxGraderType";
            this.cbxGraderType.Size = new System.Drawing.Size(121, 30);
            this.cbxGraderType.TabIndex = 28;
            this.cbxGraderType.SelectedIndexChanged += new System.EventHandler(this.cbxGraderType_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 797);
            this.Controls.Add(this.cbxGraderType);
            this.Controls.Add(this.labelGraderType1);
            this.Controls.Add(this.txtBoxGraderType);
            this.Controls.Add(this.txtBoxDepartment);
            this.Controls.Add(this.dgvGraders);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtBoxPayment);
            this.Controls.Add(this.txtBoxStipend);
            this.Controls.Add(this.txtBoxHours);
            this.Controls.Add(this.txtBoxHourlyPay);
            this.Controls.Add(this.labelPayments);
            this.Controls.Add(this.labelStipend);
            this.Controls.Add(this.labelHours);
            this.Controls.Add(this.labelHourlyPay);
            this.Controls.Add(this.labelGraderType);
            this.Controls.Add(this.txtBoxLastName);
            this.Controls.Add(this.txtBoxFirstName);
            this.Controls.Add(this.txtBoxGraderId);
            this.Controls.Add(this.labelDepartment);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelGraderID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGraders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGraderID;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelDepartment;
        private System.Windows.Forms.TextBox txtBoxGraderId;
        private System.Windows.Forms.TextBox txtBoxFirstName;
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.Label labelGraderType;
        private System.Windows.Forms.Label labelHourlyPay;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.Label labelStipend;
        private System.Windows.Forms.Label labelPayments;
        private System.Windows.Forms.TextBox txtBoxHourlyPay;
        private System.Windows.Forms.TextBox txtBoxHours;
        private System.Windows.Forms.TextBox txtBoxStipend;
        private System.Windows.Forms.TextBox txtBoxPayment;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvGraders;
        private System.Windows.Forms.TextBox txtBoxDepartment;
        private System.Windows.Forms.TextBox txtBoxGraderType;
        private System.Windows.Forms.Label labelGraderType1;
        private System.Windows.Forms.ComboBox cbxGraderType;
    }
}

