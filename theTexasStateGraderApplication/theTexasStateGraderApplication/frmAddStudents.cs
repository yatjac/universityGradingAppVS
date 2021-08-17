using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace theTexasStateGraderApplication
{
    public partial class frmAddStudents : Form
    {
        public frmAddStudents()
        {
            InitializeComponent();
        }

    
        private void btnSave_Click(object sender, EventArgs e)
        {
            int index = cbxGraderType.SelectedIndex;
            string GraderType = cbxGraderType.GetItemText(index);
            string Department = cbxDepartment.GetItemText(index);

            int id = 0;
            int hr = 0;
            int gtp = 0;
            decimal hrpay = 0;
            decimal sti = 0;
            string dept;
    
            
            try
            {
                id = int.Parse(txtBoxGraderId.Text);
                hrpay = decimal.Parse(txtBoxHourlyPay.Text);
                hr = int.Parse(txtBoxHours.Text);
                sti = decimal.Parse(txtBoxStipend.Text);
                dept = cbxDepartment.SelectedValue.ToString();
                gtp = int.Parse(cbxGraderType.Text);

            }
            catch
            {
                MessageBox.Show("Enter Number");
            }
            GraderValue g = new GraderValue
            {
                GraderId = id,
                FirstName = txtBoxFirstName.Text,
                LastName = txtBoxLastName.Text,
                HourlyPay = hrpay,
                Hours = hr,
                Stipend = sti,
                GraderType = gtp,
                Department = cbxDepartment.SelectedValue.ToString()
            };
            try
            {
                GraderDB.AddStudents(g);
                MessageBox.Show("student added successfully");
                this.DialogResult = DialogResult.OK; 
            }
            catch 
            {
                MessageBox.Show("Error");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddStudents_Load(object sender, EventArgs e)
        {
          

             List<DepartmentValue> list = DepartmentDB.GetAllDepartment();
             cbxDepartment.DataSource = list;
             cbxDepartment.DisplayMember = "DepartmentName";
             cbxDepartment.ValueMember = "DepartmentCode";

        }
    }
}
