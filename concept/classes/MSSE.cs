using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace concept.classes
{
    class MSSE:subject
    { 
        public MSSE()
        {
            subject_id = "4";
            subject_name = "MSSE";
        }
        public override DataTable get_questions()
        {
            AddQuestionInSubject(subject_id, subject_name, GetNewQuestionNumber(subject_id, subject_name), "Types of software programs are:", "Application programs", " Replicate programs", " Logical programs  ", "both A and B", 4);

            AddQuestionInSubject(subject_id, subject_name, GetNewQuestionNumber(subject_id, subject_name), "Set of programs which consist of full set of documentations is termed as", " database packages", "file packages ", " bus packages", "software packages",4 );

            AddQuestionInSubject(subject_id, subject_name, GetNewQuestionNumber(subject_id, subject_name), "Specialized program that allows user to utilize in specific application is classified as:", "relative programs", "application programs ", "relative programs", "replicate programs",2 );

            AddQuestionInSubject(subject_id, subject_name, GetNewQuestionNumber(subject_id, subject_name), "Examples of system programs includes", "operating system of computer", "trace program ", "compiler", "all of above", 4);

            AddQuestionInSubject(subject_id, subject_name, GetNewQuestionNumber(subject_id, subject_name), "Program which is used to control system performance is classified as", "experimental program ","system program","specialized program ","organized program", 2 );

            AddQuestionInSubject(subject_id, subject_name, GetNewQuestionNumber(subject_id, subject_name), " What threatens the quality and timeliness of the software to be produced?", "Known risks","Business risks"," Project risks","Technical risks",4 );

            AddQuestionInSubject(subject_id, subject_name, GetNewQuestionNumber(subject_id, subject_name), "What threatens the viability of the software to be built?","Known risks","Business risks","Project risks","Technical risks",2 );

            AddQuestionInSubject(subject_id, subject_name, GetNewQuestionNumber(subject_id, subject_name), " A make-buy decision is based on whether","The software may be purchased off-the-shelf", "Full-experience or “Partial-experience” software components should be used","Customer-built software should be developed","All of the mentioned",4 );

            AddQuestionInSubject(subject_id, subject_name, GetNewQuestionNumber(subject_id, subject_name), " A design description in OOD includes", "Protocol Description","Implementation Description"," Type Description","both Protocol and Implementation Description", 4 );

            AddQuestionInSubject(subject_id, subject_name, GetNewQuestionNumber(subject_id, subject_name), " How many layers are present in the OO design pyramid?", "three", "four ", "five", "one", 2);

          
            return dt_questions;

        }
        
    }
}
