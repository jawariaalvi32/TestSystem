using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace concept.classes
{
   abstract class subject
    {
      public string subject_name;
      public  string subject_id;
       public abstract DataTable get_questions();

        public DataTable dt_questions = new DataTable();
        public subject()
        {
            
            dt_questions.Columns.Add("id");                     
            dt_questions.Columns.Add("subjects");              
            dt_questions.Columns.Add("question_no");            
            dt_questions.Columns.Add("questions");             
            dt_questions.Columns.Add("option_1");              
            dt_questions.Columns.Add("option_2");
            dt_questions.Columns.Add("option_3");
            dt_questions.Columns.Add("option_4");
            dt_questions.Columns.Add("correct_options");
        }
        public void AddQuestionInSubject(string id, string subjectname, int question_no, string question, string opt1, string opt2, string opt3, string opt4, int correct_opt)
        {
            DataRow dr = dt_questions.NewRow();
            dr["id"] = id;                                        
            dr["subjects"] = subjectname;                        
            dr["question_no"] = question_no;                     
            dr["questions"] = question;
            dr["option_1"] = opt1;
            dr["option_2"] = opt2;
            dr["option_3"] = opt3;
            dr["option_4"] = opt4;
            dr["correct_options"] = correct_opt;
            dt_questions.Rows.Add(dr);
        }
        public int GetNewQuestionNumber(string subject_id, string subject_name)
        {
            int maxQuestionNum = 0;
            for (int i = 0; i < dt_questions.Rows.Count; i++)
            {
                if (dt_questions.Rows[i]["id"].ToString() == subject_id && dt_questions.Rows[i]["subjects"].ToString() == subject_name)
                {
                    if (Convert.ToInt32(dt_questions.Rows[i]["question_no"]) > maxQuestionNum)
                    {
                        maxQuestionNum = Convert.ToInt32(dt_questions.Rows[i]["question_no"]);
                    }
                }

            }
            return maxQuestionNum + 1;
        }
        public int GetNewQuestionNumber(string subject_id, string subject_name, DataTable dt_questions)
        {
            int maxQuestionNum = 0;
            for (int i = 0; i < dt_questions.Rows.Count; i++)
            {
                if (dt_questions.Rows[i]["id"].ToString() == subject_id && dt_questions.Rows[i]["subjects"].ToString() == subject_name)
                {
                    if (Convert.ToInt32(dt_questions.Rows[i]["question_no"]) > maxQuestionNum)
                    {
                        maxQuestionNum = Convert.ToInt32(dt_questions.Rows[i]["question_no"]);
                    }
                }

            }
            return maxQuestionNum + 1;
        }

    }
    
    
    
}
