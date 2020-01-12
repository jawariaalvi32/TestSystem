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
    public partial class frm_admin_login : Form
    {
        public frm_admin_login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            if (username == AdminCredentials.username && password == AdminCredentials.password)
            {
                QuestionsPanel obj = new QuestionsPanel();
                obj.Show();
                this.Hide();
            }
            else
                MessageBox.Show("please enter correct username or password.......!!!");
        }

        private void frm_admin_login_Load(object sender, EventArgs e)
        {
            label3.BackColor = Color.Transparent;
         

        }

        private void btn_back2_Click(object sender, EventArgs e)
        {
            FRM_MAIN obj = new FRM_MAIN();
            obj.Show();
            this.Hide();

        }


    }
}
