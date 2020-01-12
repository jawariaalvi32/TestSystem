using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using concept.classes;
namespace concept
{
    public partial class StudentForm : Form
    {
        
        public StudentForm()
        {
            InitializeComponent(); 
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_StartTest_Click(object sender, EventArgs e)
        {
            if (txt_name.Text==""|| txt_age.Text==""||txt_email.Text==""||txt_mobile.Text==""||txt_qualification.Text==""||cmb_subjects.SelectedIndex==0)
            {
                //MessageBox.Show("please fill the form ......");
                lbl_error.Visible = true;
            }
            else
            {
                lbl_error.Visible = false;
                students obj = new students(txt_name.Text, txt_email.Text, txt_qualification.Text, txt_mobile.Text, Convert.ToInt32(txt_age.Text), cmb_subjects.SelectedItem.ToString());
                frmTest obj_test = new frmTest(txt_name.Text, txt_email.Text, txt_qualification.Text, txt_mobile.Text, Convert.ToInt32(txt_age.Text), cmb_subjects.SelectedItem.ToString());
                
                obj_test.Show();
                this.Hide();  
            }
           
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            Questions obj = new Questions();
            DataTable dt_questions = new DataTable();
            dt_questions = obj.GetAllQuestionsTable();

            string[] columns = { "subjects"};
            DataTable dt_subjects = new DataTable();
            dt_subjects = dt_questions.DefaultView.ToTable(true, columns);

            for (int i=0;i<dt_subjects.Rows.Count;i++)
            {
                cmb_subjects.Items.Add(dt_subjects.Rows[i][0].ToString());
            }
            cmb_subjects.Items.Insert(0,"Select");
            cmb_subjects.SelectedIndex = 0;

            lbl_error.Visible = false;

        }

        private void cmb_subjects_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            FRM_MAIN obj = new FRM_MAIN();
            obj.Show();
            this.Hide();
        }
    }
}
