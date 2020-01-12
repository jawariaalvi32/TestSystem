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
    public partial class frmTest : Form
    {
        string name;
        string email;
        string qualification;
        string mobile;
        string subject;
        int age;
        int position_index = 0;
        DataTable dt_QuestionsOfSelectedSubject = new DataTable();
        double ObtainedMarks = 0;
        double TotalMarks = 0;
        double percentage ;
        double countOfRightAnswers=0;
        public frmTest()
        {

            InitializeComponent();
           
           
        }
        public frmTest(string name, string email, string qualification, string mob_no, int age, string subject)
        {
            InitializeComponent();
            this.name = name;
            this.email = email;
            this.qualification = qualification;
            this.mobile = mob_no;
            this.subject = subject;
            this.age = age;
           
            

           
        }

        private void frmTest_Load(object sender, EventArgs e)
        {
            lbl_welcome.Text = "WELCOME  "+name;
            lbl_name.Text = "SELECTED SUBJECT:" + subject;
            
            Questions obj = new Questions();
            DataTable dt_questions = new DataTable();
            dt_questions = obj.GetAllQuestionsTable();
            
            dt_QuestionsOfSelectedSubject.Columns.Add("id");
            dt_QuestionsOfSelectedSubject.Columns.Add("subjects");
            dt_QuestionsOfSelectedSubject.Columns.Add("question_no");
            dt_QuestionsOfSelectedSubject.Columns.Add("questions");
            dt_QuestionsOfSelectedSubject.Columns.Add("option_1");
            dt_QuestionsOfSelectedSubject.Columns.Add("option_2");
            dt_QuestionsOfSelectedSubject.Columns.Add("option_3");
            dt_QuestionsOfSelectedSubject.Columns.Add("option_4");
            dt_QuestionsOfSelectedSubject.Columns.Add("correct_options");
            for (int i=0;i<dt_questions.Rows.Count;i++)
            {
                if ( dt_questions.Rows[i]["subjects"].ToString() == subject)
                {
                    DataRow dr = dt_QuestionsOfSelectedSubject.NewRow();
                    dr["id"] = dt_questions.Rows[i]["id"].ToString();
                    dr["subjects"] = dt_questions.Rows[i]["subjects"].ToString();
                    dr["question_no"] = dt_questions.Rows[i]["question_no"].ToString();
                    dr["questions"] = dt_questions.Rows[i]["questions"].ToString();
                    dr["option_1"] = dt_questions.Rows[i]["option_1"].ToString();
                    dr["option_2"] = dt_questions.Rows[i]["option_2"].ToString();
                    dr["option_3"] = dt_questions.Rows[i]["option_3"].ToString();
                    dr["option_4"] = dt_questions.Rows[i]["option_4"].ToString();
                    dr["correct_options"] = dt_questions.Rows[i]["correct_options"].ToString();
                    dt_QuestionsOfSelectedSubject.Rows.Add(dr);

                }

            }
            PrintQuestion(dt_QuestionsOfSelectedSubject,position_index);
           
        }
        public void PrintQuestion(DataTable dt_QuestionsOfSelectedSubject,int position) 
        {
            lbl_qno.Text = dt_QuestionsOfSelectedSubject.Rows[position]["question_no"].ToString();
            lbl_question.Text = dt_QuestionsOfSelectedSubject.Rows[position]["questions"].ToString();
            r_opt1.Text = dt_QuestionsOfSelectedSubject.Rows[position]["option_1"].ToString();
            r_opt2.Text = dt_QuestionsOfSelectedSubject.Rows[position]["option_2"].ToString();
            r_opt3.Text = dt_QuestionsOfSelectedSubject.Rows[position]["option_3"].ToString();
            r_opt4.Text = dt_QuestionsOfSelectedSubject.Rows[position]["option_4"].ToString();
            TotalMarks += 5;
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            int selectedOption = 0;
            if(r_opt1.Checked==true)
            {
                selectedOption = 1;
            }
            else if(r_opt2.Checked==true)
            {
                selectedOption = 2;
            }
            else if (r_opt3.Checked == true)
            {
                selectedOption = 3;
            }
            else if (r_opt4.Checked == true)
            {
                selectedOption = 4;
            }
            int correctOption = Convert.ToInt32(dt_QuestionsOfSelectedSubject.Rows[position_index]["correct_options"]);
            if(selectedOption==correctOption)
            {
                ObtainedMarks += 5;
                countOfRightAnswers++;
            }

            if (position_index == dt_QuestionsOfSelectedSubject.Rows.Count - 1)//if this is last 
            {
                frmResults frmresult = new frmResults(name, email, qualification, mobile, subject, age, ObtainedMarks, TotalMarks, percentage,countOfRightAnswers);
                frmresult.Show();
                this.Hide();
            }
            else
            {
                position_index++;//index of questions in data table next p icr hoga agla swal aeyga 
                PrintQuestion(dt_QuestionsOfSelectedSubject, position_index);
                if (position_index == dt_QuestionsOfSelectedSubject.Rows.Count - 1)
                {
                    btn_Next.Text = "Submit & View Results";
                    

                }

            }
            
        }
        
    }
}
