using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace concept.classes
{
    class bscs : subject
    {
        public bscs()
        {
            subject_id = "2";
            subject_name = "BSCS";
          
        }
        public override DataTable get_questions()
        {
            AddQuestionInSubject(subject_id, subject_name, GetNewQuestionNumber(subject_id, subject_name), "Notebook PCs fall into a category of devices called", "mobile computers ", "desktop computers ", " hybrid computers", "tabulators",1 );
            AddQuestionInSubject(subject_id, subject_name, GetNewQuestionNumber(subject_id, subject_name), "A hard disk is divided into tracks, which are further subdivided into", "clusters ", "sectors", "vectors ", "heads",2 );
            AddQuestionInSubject(subject_id, subject_name, GetNewQuestionNumber(subject_id, subject_name), "Given X1=12,X2=19,X3=10,X4=7, then ∑4i=1 equals?  ", "36", " 48", " 41", "29", 2);
            AddQuestionInSubject(subject_id, subject_name, GetNewQuestionNumber(subject_id, subject_name), "A constant variable can take values", " zero", " fixed", " not fixed", "nothing", 2);
            AddQuestionInSubject(subject_id, subject_name, GetNewQuestionNumber(subject_id, subject_name), " Express -15 as a 6-bit signed binary number.", " 001111", "  101111", " 101110", " 001110", 2);
            AddQuestionInSubject(subject_id, subject_name, GetNewQuestionNumber(subject_id, subject_name), " The error that can be pointed out by the compiler are", "syntax errors ", "semantic errors  ", "logical errors ", "internal errors ", 1);
            AddQuestionInSubject(subject_id, subject_name, GetNewQuestionNumber(subject_id, subject_name), " A system program that set up an executable program in main memory ready for execution is", " assembler", "linker", " loader", " text-editor", 3);
            AddQuestionInSubject(subject_id, subject_name, GetNewQuestionNumber(subject_id, subject_name), "which of the following are language processors ", "assembler ", "compilers  ", "interpreter ", "all of these ",1 );
            AddQuestionInSubject(subject_id, subject_name, GetNewQuestionNumber(subject_id, subject_name), "The order of differential equation is always "," Positive integer" ," Negative integer ", "Rational number", "Whole number ",1 );
            AddQuestionInSubject(subject_id, subject_name, GetNewQuestionNumber(subject_id, subject_name), "The differential equation dy/dx=y^2 is: ", "linear ", "non-linear  ", "quasilinear ", "non of above ",2 );
           
            return dt_questions;

        }
       
    }
}
