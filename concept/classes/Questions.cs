using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace concept.classes
{
    class Questions
    {
     public static   DataTable dt_questions = new DataTable();
     public Questions()
     {
        


        }
        public DataTable GetAllQuestionsTable()
        {
            if (dt_questions == null || dt_questions.Rows.Count==0)
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

                BSSE obj = new BSSE();
                DataTable dt_bs ;
                dt_bs= obj.get_questions();
                AddQuestionsToMasterTable(dt_bs);

                bscs obj1 = new bscs();
                DataTable dt_bscs = obj1.get_questions();
                AddQuestionsToMasterTable(dt_bscs);

                MSCS obj2 = new MSCS();
                DataTable dt_mscs = obj2.get_questions();
                AddQuestionsToMasterTable(dt_mscs);

                MSSE obj3 = new MSSE();
                DataTable dt_ms = obj3.get_questions();
                AddQuestionsToMasterTable(dt_ms);
                return dt_questions;
            }
            else
            {
                return dt_questions;
            }
            
        }
        private void AddQuestionsToMasterTable(DataTable dt) 
        {
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt_questions.NewRow();
                dr["id"] = dt.Rows[i]["id"].ToString();
                dr["subjects"] = dt.Rows[i]["subjects"].ToString();
                dr["question_no"] = dt.Rows[i]["question_no"].ToString();
                dr["questions"] = dt.Rows[i]["questions"].ToString();

                dr["option_1"] = dt.Rows[i]["option_1"].ToString();
                dr["option_2"] = dt.Rows[i]["option_2"].ToString();
                dr["option_3"] = dt.Rows[i]["option_3"].ToString();
                dr["option_4"] = dt.Rows[i]["option_4"].ToString();
                dr["correct_options"] = dt.Rows[i]["correct_options"].ToString();
                dt_questions.Rows.Add(dr);
            }
        }
        
    }
}
