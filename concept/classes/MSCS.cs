using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace concept.classes
{
    class MSCS : subject
    {
        public MSCS()
        {
            subject_id = "2";
            subject_name = "MSCS";
           
        }
        public override DataTable get_questions()
        {
            //int new_QuestionNUmber = 0;
            //new_QuestionNUmber = GetNewQuestionNumber(subject_id, subject_name);
            //AddQuestionInSubject(subject_id, subject_name, new_QuestionNUmber, "", "", " ", "", "", 1);
            AddQuestionInSubject(subject_id, subject_name, GetNewQuestionNumber(subject_id, subject_name), "Raw Data is processed by the computer into :", "number sheets ", "updates ", "paragraphs ", "information", 1);
            AddQuestionInSubject(subject_id, subject_name, GetNewQuestionNumber(subject_id, subject_name), "loading of operating system in a personal computeris called:", "prompting ", "booting", "interrupting ", "paging", 2);            
            AddQuestionInSubject(subject_id, subject_name, GetNewQuestionNumber(subject_id, subject_name), "network of networks is:", " internet ", "intranet ", "lan ", "all of above", 1);
            AddQuestionInSubject(subject_id, subject_name, GetNewQuestionNumber(subject_id, subject_name), " Which of the following is not a data type?","Numeric Data","Alphanumeric Data","Symbolic Data","Alphabetic Data", 3);
            AddQuestionInSubject(subject_id, subject_name, GetNewQuestionNumber(subject_id, subject_name), "*@Ac# is a type of ________________ data.", "Symbolic", "Alphanumeric","Alphabetic","Numeric ", 2);
            AddQuestionInSubject(subject_id, subject_name, GetNewQuestionNumber(subject_id, subject_name), "The number of clock cycles per second is referred as ________", "Clock speed","Clock frequency","Clock rate","Clock timing ",1 );
            AddQuestionInSubject(subject_id, subject_name, GetNewQuestionNumber(subject_id, subject_name), " Which of the following is not a point-and-draw device?","Keypad","Trackball", "Touch screen","Mouse", 1 );
            AddQuestionInSubject(subject_id, subject_name, GetNewQuestionNumber(subject_id, subject_name), "Which of the following is a type of image scanner?"," Flat-held","Hand-led","Flat-bed","Compact", 3);
            AddQuestionInSubject(subject_id, subject_name, GetNewQuestionNumber(subject_id, subject_name), "The LSB and MSB of 1243247 are ____ and ____","1, 7","4, 7","7, 1","4, 1",3 );
            AddQuestionInSubject(subject_id, subject_name, GetNewQuestionNumber(subject_id, subject_name), "The technology used in optical disks is ______","Reflective","Refractive","Laser Beam","Diffraction", 3 );

            return dt_questions;

        }
    }
}
