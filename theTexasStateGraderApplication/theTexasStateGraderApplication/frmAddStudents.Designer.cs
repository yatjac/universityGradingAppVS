namespace theTexasStateGraderApplication
{
    partial class frmAddStudents
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
            this.components = new System.ComponentModel.Container();
            this.labelGraderId = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.labelGraderType = new System.Windows.Forms.Label();
            this.labelHourlyPay = new System.Windows.Forms.Label();
            this.labelHours = new System.Windows.Forms.Label();
            this.labelStipend = new System.Windows.Forms.Label();
            this.txtBoxGraderId = new System.Windows.Forms.TextBox();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.txtBoxHourlyPay = new System.Windows.Forms.TextBox();
            this.txtBoxHours = new System.Windows.Forms.TextBox();
            this.txtBoxStipend = new System.Windows.Forms.TextBox();
            this.cbxDepartment = new System.Windows.Forms.ComboBox();
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cis3325_studentsDataSet = new theTexasStateGraderApplication.cis3325_studentsDataSet();
            this.cbxGraderType = new System.Windows.Forms.ComboBox();
            this.gradersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cis3325_studentsDataSet1 = new theTexasStateGraderApplication.cis3325_studentsDataSet1();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.departmentsTableAdapter = new theTexasStateGraderApplication.cis3325_studentsDataSetTableAdapters.DepartmentsTableAdapter();
            this.gradersTableAdapter = new theTexasStateGraderApplication.cis3325_studentsDataSet1TableAdapters.GradersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cis3325_studentsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cis3325_studentsDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelGraderId
            // 
            this.labelGraderId.AutoSize = true;
            this.labelGraderId.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGraderId.Location = new System.Drawing.Point(88, 73);
            this.labelGraderId.Name = "labelGraderId";
            this.labelGraderId.Size = new System.Drawing.Size(95, 21);
            this.labelGraderId.TabIndex = 0;
            this.labelGraderId.Text = "Grader ID:";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.Location = new System.Drawing.Point(86, 133);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(105, 21);
            this.labelFirstName.TabIndex = 1;
            this.labelFirstName.Text = "First Name:";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.Location = new System.Drawing.Point(88, 194);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(102, 21);
            this.labelLastName.TabIndex = 2;
            this.labelLastName.Text = "Last Name:";
            // 
            // labelDepartment
            // 
            this.labelDepartment.AutoSize = true;
            this.labelDepartment.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDepartment.Location = new System.Drawing.Point(88, 245);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(112, 21);
            this.labelDepartment.TabIndex = 3;
            this.labelDepartment.Text = "Department:";
            // 
            // labelGraderType
            // 
            this.labelGraderType.AutoSize = true;
            this.labelGraderType.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGraderType.Location = new System.Drawing.Point(412, 73);
            this.labelGraderType.Name = "labelGraderType";
            this.labelGraderType.Size = new System.Drawing.Size(375, 21);
            this.labelGraderType.TabIndex = 4;
            this.labelGraderType.Text = "Grader Type (0: Undergraduate, 1: Graduate):";
            // 
            // labelHourlyPay
            // 
            this.labelHourlyPay.AutoSize = true;
            this.labelHourlyPay.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHourlyPay.Location = new System.Drawing.Point(412, 133);
            this.labelHourlyPay.Name = "labelHourlyPay";
            this.labelHourlyPay.Size = new System.Drawing.Size(106, 21);
            this.labelHourlyPay.TabIndex = 5;
            this.labelHourlyPay.Text = "Hourly Pay:";
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHours.Location = new System.Drawing.Point(412, 194);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(67, 21);
            this.labelHours.TabIndex = 6;
            this.labelHours.Text = "Hours:";
            // 
            // labelStipend
            // 
            this.labelStipend.AutoSize = true;
            this.labelStipend.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStipend.Location = new System.Drawing.Point(412, 240);
            this.labelStipend.Name = "labelStipend";
            this.labelStipend.Size = new System.Drawing.Size(77, 21);
            this.labelStipend.TabIndex = 7;
            this.labelStipend.Text = "Stipend:";
            // 
            // txtBoxGraderId
            // 
            this.txtBoxGraderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxGraderId.Location = new System.Drawing.Point(204, 69);
            this.txtBoxGraderId.Name = "txtBoxGraderId";
            this.txtBoxGraderId.Size = new System.Drawing.Size(100, 28);
            this.txtBoxGraderId.TabIndex = 8;
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxFirstName.Location = new System.Drawing.Point(204, 128);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(100, 28);
            this.txtBoxFirstName.TabIndex = 9;
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLastName.Location = new System.Drawing.Point(204, 187);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(100, 28);
            this.txtBoxLastName.TabIndex = 10;
            // 
            // txtBoxHourlyPay
            // 
            this.txtBoxHourlyPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxHourlyPay.Location = new System.Drawing.Point(524, 129);
            this.txtBoxHourlyPay.Name = "txtBoxHourlyPay";
            this.txtBoxHourlyPay.Size = new System.Drawing.Size(100, 28);
            this.txtBoxHourlyPay.TabIndex = 11;
            // 
            // txtBoxHours
            // 
            this.txtBoxHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxHours.Location = new System.Drawing.Point(524, 190);
            this.txtBoxHours.Name = "txtBoxHours";
            this.txtBoxHours.Size = new System.Drawing.Size(100, 28);
            this.txtBoxHours.TabIndex = 12;
            // 
            // txtBoxStipend
            // 
            this.txtBoxStipend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxStipend.Location = new System.Drawing.Point(524, 238);
            this.txtBoxStipend.Name = "txtBoxStipend";
            this.txtBoxStipend.Size = new System.Drawing.Size(100, 28);
            this.txtBoxStipend.TabIndex = 13;
            // 
            // cbxDepartment
            // 
            this.cbxDepartment.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.departmentsBindingSource, "DepartmentName", true));
            this.cbxDepartment.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDepartment.FormattingEnabled = true;
            this.cbxDepartment.Location = new System.Drawing.Point(204, 237);
            this.cbxDepartment.Name = "cbxDepartment";
            this.cbxDepartment.Size = new System.Drawing.Size(121, 29);
            this.cbxDepartment.TabIndex = 14;
            // 
            // departmentsBindingSource
            // 
            this.departmentsBindingSource.DataMember = "Departments";
            this.departmentsBindingSource.DataSource = this.cis3325_studentsDataSet;
            // 
            // cis3325_studentsDataSet
            // 
            this.cis3325_studentsDataSet.DataSetName = "cis3325_studentsDataSet";
            this.cis3325_studentsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbxGraderType
            // 
            this.cbxGraderType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.gradersBindingSource, "GraderType", true));
            this.cbxGraderType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxGraderType.FormattingEnabled = true;
            this.cbxGraderType.Items.AddRange(new object[] {
            "0",
            "1"});
            this.cbxGraderType.Location = new System.Drawing.Point(823, 64);
            this.cbxGraderType.Name = "cbxGraderType";
            this.cbxGraderType.Size = new System.Drawing.Size(121, 30);
            this.cbxGraderType.TabIndex = 15;
            // 
            // gradersBindingSource
            // 
            this.gradersBindingSource.DataMember = "Graders";
            this.gradersBindingSource.DataSource = this.cis3325_studentsDataSet1;
            // 
            // cis3325_studentsDataSet1
            // 
            this.cis3325_studentsDataSet1.DataSetName = "cis3325_studentsDataSet1";
            this.cis3325_studentsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(204, 377);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 42);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(519, 377);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 42);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // departmentsTableAdapter
            // 
            this.departmentsTableAdapter.ClearBeforeFill = true;
            // 
            // gradersTableAdapter
            // 
            this.gradersTableAdapter.ClearBeforeFill = true;
            // 
            // frmAddStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 668);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbxGraderType);
            this.Controls.Add(this.cbxDepartment);
            this.Controls.Add(this.txtBoxStipend);
            this.Controls.Add(this.txtBoxHours);
            this.Controls.Add(this.txtBoxHourlyPay);
            this.Controls.Add(this.txtBoxLastName);
            this.Controls.Add(this.txtBoxFirstName);
            this.Controls.Add(this.txtBoxGraderId);
            this.Controls.Add(this.labelStipend);
            this.Controls.Add(this.labelHours);
            this.Controls.Add(this.labelHourlyPay);
            this.Controls.Add(this.labelGraderType);
            this.Controls.Add(this.labelDepartment);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.labelGraderId);
            this.Name = "frmAddStudents";
            this.Text = "frmAddStudents";
            this.Load += new System.EventHandler(this.frmAddStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cis3325_studentsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cis3325_studentsDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGraderId;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelDepartment;
        private System.Windows.Forms.Label labelGraderType;
        private System.Windows.Forms.Label labelHourlyPay;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.Label labelStipend;
        private System.Windows.Forms.TextBox txtBoxGraderId;
        private System.Windows.Forms.TextBox txtBoxFirstName;
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.TextBox txtBoxHourlyPay;
        private System.Windows.Forms.TextBox txtBoxHours;
        private System.Windows.Forms.TextBox txtBoxStipend;
        private System.Windows.Forms.ComboBox cbxDepartment;
        private System.Windows.Forms.ComboBox cbxGraderType;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private cis3325_studentsDataSet cis3325_studentsDataSet;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
        private cis3325_studentsDataSetTableAdapters.DepartmentsTableAdapter departmentsTableAdapter;
        private cis3325_studentsDataSet1 cis3325_studentsDataSet1;
        private System.Windows.Forms.BindingSource gradersBindingSource;
        private cis3325_studentsDataSet1TableAdapters.GradersTableAdapter gradersTableAdapter;
    }
}