using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace concept
{
    public partial class FRM_MAIN : Form
    {
        public FRM_MAIN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FRM_MAIN_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Yellow;
          
            lbl_admin.BackColor = Color.Yellow;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            btn_admin.BackColor = Color.Transparent;
            btn_student.BackColor = Color.Transparent;

        }

        private void btn_student_Click(object sender, EventArgs e)
        {
            StudentForm obj = new StudentForm();
            obj.Show();
            this.Hide();
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            frm_admin_login obj = new frm_admin_login();
            obj.Show();
            this.Hide();
        }
    }
}
