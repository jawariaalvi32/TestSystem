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
    public partial class QuestionsPanel : Form
    {
        DataTable dt_questions = new DataTable();
        public QuestionsPanel()
        {
            InitializeComponent();
        }

        private void QuestionsPanel_Load(object sender, EventArgs e)
        {
            Questions obj = new Questions();
           
            dt_questions = obj.GetAllQuestionsTable();
            gv_questions.DataSource = dt_questions;
            DataTable dt_subjects = new DataTable();
            //string[] columns = { "subjects" };  
            //dt_subjects = dt_questions.DefaultView.ToTable(true, columns);
            //for distinct subj
            dt_subjects = dt_questions.DefaultView.ToTable(true, "subjects"); 

            for (int i = 0; i < dt_subjects.Rows.Count; i++)
            {
                cmb_subject.Items.Add(dt_subjects.Rows[i][0].ToString());
            }
            cmb_subject.Items.Insert(0, "Select");
            cmb_subject.SelectedIndex = 0;
         
            cbm_option.Items.Insert(0, "select");
            cbm_option.SelectedIndex = 0;  
            cbm_option.Items.Insert(1, 1);
            cbm_option.Items.Insert(2, 2);
            cbm_option.Items.Insert(3, 3);
            cbm_option.Items.Insert(4, 4);
            btn_update.Visible = false;
            btn_dlt.Visible = false;
            btn_cncl_edit.Visible = false;
        }

        private void gv_questions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_MAIN obj = new FRM_MAIN();
            obj.Show();
            this.Hide();
        }
        
        private void gv_questions_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int idx = e.RowIndex;
           lbl_id.Text = gv_questions.Rows[idx].Cells[0].Value.ToString();
           SetSelectedsubject(gv_questions.Rows[idx].Cells[1].Value.ToString());
            lbl_question.Text = gv_questions.Rows[idx].Cells[2].Value.ToString();
            txt_question.Text = gv_questions.Rows[idx].Cells[3].Value.ToString();
            txt_optm1.Text = gv_questions.Rows[idx].Cells[4].Value.ToString();
            txt_optn2.Text = gv_questions.Rows[idx].Cells[5].Value.ToString();
            txt_optn3.Text = gv_questions.Rows[idx].Cells[6].Value.ToString();
            txt_optn4.Text = gv_questions.Rows[idx].Cells[7].Value.ToString();
            //cbm_option.SelectedText = gv_questions.Rows[idx].Cells[8].Value.ToString();
            SetCorrectOption(gv_questions.Rows[idx].Cells[8].Value.ToString()); 
            btn_insert.Visible = false;
            btn_cncl_edit.Visible = true;
            btn_dlt.Visible = true;
            btn_update.Visible = true;

            
        }
        public void SetSelectedsubject(string subject) 
        {
            for (int i = 0; i < cmb_subject.Items.Count; i++)
            {
                if(cmb_subject.Items[i].ToString()==subject)
                {
                    cmb_subject.SelectedIndex = i;
                }
                
            }
        }
        public void SetCorrectOption(string correct_option )
        {
            for (int i = 0; i < cbm_option.Items.Count; i++)
            {
                if (cbm_option.Items[i].ToString()==correct_option)
                {
                    cbm_option.SelectedIndex = i;
                    
                }
                
            }
        }

        private void btn_cncl_edit_Click(object sender, EventArgs e)
        {
            btn_insert.Visible = true;
            btn_cncl_edit.Visible = false;
            btn_update.Visible = false;
            btn_dlt.Visible = false;
            ClearFields();
        }
        public void ClearFields()
        {
            txt_question.Text="";
            txt_optm1.Text = "";
            txt_optn2.Text = "";
            txt_optn3.Text = "";
            txt_optn4.Text = "";
            cbm_option.SelectedIndex = 0;
            cmb_subject.SelectedIndex = 0;

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_question.Text == "" || txt_optm1.Text == "" || txt_optn2.Text == "" || txt_optn3.Text == "" || txt_optn4.Text == "" || cmb_subject.SelectedIndex == 0 || cbm_option.SelectedIndex == 0)
            {
                MessageBox.Show("please enter all fields...");
            }
            else 
            {
                for (int i = 0; i < dt_questions.Rows.Count; i++)
                {
                    if ((dt_questions.Rows[i]["id"].ToString() == lbl_id.Text) && (dt_questions.Rows[i]["question_no"].ToString() == lbl_question.Text))
                    {
                        dt_questions.Rows[i]["subjects"] = cmb_subject.SelectedItem.ToString();

                        dt_questions.Rows[i]["questions"] = txt_question.Text;
                        dt_questions.Rows[i]["option_1"] = txt_optm1.Text;
                        dt_questions.Rows[i]["option_2"] = txt_optn2.Text;
                        dt_questions.Rows[i]["option_3"] = txt_optn3.Text;
                        dt_questions.Rows[i]["option_4"] = txt_optn4.Text;
                        dt_questions.Rows[i]["correct_options"] = cbm_option.SelectedItem.ToString();

                        MessageBox.Show("Updated Successfully");
                        gv_questions.DataSource = dt_questions;
                        break;

                    }
                }
            }
            
        }

        private void btn_dlt_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dt_questions.Rows.Count; i++)
            {
                if ((dt_questions.Rows[i]["id"].ToString() == lbl_id.Text) && (dt_questions.Rows[i]["question_no"].ToString() == lbl_question.Text))
                {
                    //dt_questions.Rows.RemoveAt(i);
                    dt_questions.Rows[i].Delete();

                    MessageBox.Show("Deleted Successfully");
                    gv_questions.DataSource = dt_questions;
                    break;

                }
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (txt_question.Text==""||txt_optm1.Text==""||txt_optn2.Text==""||txt_optn3.Text==""||txt_optn4.Text==""|| cmb_subject.SelectedIndex==0||cbm_option.SelectedIndex==0)
            {
                MessageBox.Show("please enter your questios....");
                
            }
            else
            {   //A a;
                //a= new B();
                //A obj = new B();
                subject obj;
               if (cmb_subject.SelectedItem.ToString()=="BSSE")
            {
                obj = new BSSE();              
               
            }
               else if(cmb_subject.SelectedItem.ToString()=="BSCS")
               {
                   obj = new bscs();
               }
               else if (cmb_subject.SelectedItem.ToString()=="MSCS")
               {
                   obj = new MSCS(); 
                   
               }
               else if (cmb_subject.SelectedItem.ToString() == "MSSE")
               {
                   obj = new MSSE();
                  

               }
               else 
               {
                   obj = new bscs();
               }
               
               DataRow dr = dt_questions.NewRow();
               dr["id"] = obj.subject_id;
               dr["subjects"] = obj.subject_name;
               dr["question_no"] = obj.GetNewQuestionNumber(obj.subject_id, obj.subject_name,dt_questions);
               dr["questions"] = txt_question.Text;
               dr["option_1"] = txt_optm1.Text;
               dr["option_2"] = txt_optn2.Text;
               dr["option_3"] = txt_optn3.Text;
               dr["option_4"] = txt_optn4.Text;
               dr["correct_options"] = cbm_option.SelectedItem;
               dt_questions.Rows.Add(dr);
               MessageBox.Show("question inserted Successfully");

               gv_questions.DataSource = dt_questions;
        }
                    
        }

        private void cmb_subject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
