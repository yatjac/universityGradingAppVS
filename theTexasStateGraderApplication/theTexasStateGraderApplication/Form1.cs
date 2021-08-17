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

namespace theTexasStateGraderApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        private void Form1_Load(object sender, EventArgs e)
        {
            List<GraderValue> list = GraderDB.GetAllGraders();

            dgvGraders.DataSource = list;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddStudents form = new frmAddStudents();
            DialogResult r = form.ShowDialog();
            if (r == DialogResult.OK)
            {
                List<GraderValue> listGrader = GraderDB.GetAllGraders();

                dgvGraders.DataSource = listGrader;
            }
        }
        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int graderid = (int)dgvGraders.CurrentRow.Cells[0].Value;
            GraderValue g = GraderDB.GetGrader(graderid);
            if (g != null)
            {
                try
                {
                    GraderDB.DeleteGrader(g);
                    MessageBox.Show("Student deleted successfully");
                }
                catch (Exception ex)
                {
                    throw ex;
                }

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvGraders_SelectionChanged(object sender, EventArgs e)
        {
            int graderid = (int)dgvGraders.CurrentRow.Cells[0].Value;
                    
            GraderValue g = GraderDB.GetGrader(graderid);
            if (g != null)
            {
                txtBoxGraderId.Text = g.GraderId.ToString();
                txtBoxFirstName.Text = g.FirstName;
                txtBoxLastName.Text = g.LastName;
                txtBoxDepartment.Text = g.Department;
                txtBoxGraderType.Text = g.GraderType.ToString();
                txtBoxHourlyPay.Text = g.HourlyPay.ToString("c");
                txtBoxHours.Text = g.Hours.ToString("n");
                txtBoxStipend.Text = g.Stipend.ToString("c");
                txtBoxPayment.Text = g.getPayment().ToString("c");
            }
            else
            {
                MessageBox.Show("enter valid id");
            }
        }

        private void cbxGraderType_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<GraderValue> list = GraderDB.GetGraderByGraderType(cbxGraderType.Text);

            dgvGraders.DataSource = list;

        }
    }
}
