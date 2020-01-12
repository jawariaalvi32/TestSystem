using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace concept.classes
{
    class BSSE:subject
    {
        
        public BSSE()
        {
            subject_id = "1";
            subject_name = "BSSE";
       
        }
        public override DataTable get_questions()
        {
            AddQuestionInSubject(subject_id, subject_name, GetNewQuestionNumber(subject_id, subject_name), "what is software?", "Set of computer programs, procedures and possibly associated document concerned with the operation of data processing.", " A set of compiler instructions", " A mathematical formula  ", "None of above",1);

            AddQuestionInSubject(subject_id, subject_name, GetNewQuestionNumber(subject_id, subject_name), "Which of the following is not the characteristic of software ?", " Software does not wear out", " Software is flexible", " Software is not manufactured", "Software is always correct", 4);
           
            AddQuestionInSubject(subject_id, subject_name, GetNewQuestionNumber(subject_id, subject_name), "Management of software development is dependent upon ?", " People", " product", " process", "all of abive", 4);
           
            AddQuestionInSubject(subject_id, subject_name, GetNewQuestionNumber(subject_id, subject_name), "During software development which factor is most crucial ?", "people", " product", " process", "project", 1);

            AddQuestionInSubject(subject_id, subject_name, GetNewQuestionNumber(subject_id, subject_name), "Milestones are used to ?", " Know the cost of the project", " Know the status of the project", " Know the user expectations", "None of the above", 1);

            AddQuestionInSubject(subject_id, subject_name, GetNewQuestionNumber(subject_id, subject_name), "Which model is popular for students small projects ?", " Waterfall Model", " Spiral Model", " Quick and Fix model", "Prototyping Model", 1);

            AddQuestionInSubject(subject_id, subject_name, GetNewQuestionNumber(subject_id, subject_name), "Project risk factor is considered in ?", " Spiral Model", " waterfall model", " Prototyping Model", "Iterative enhancement Model", 1);

            AddQuestionInSubject(subject_id, subject_name, GetNewQuestionNumber(subject_id, subject_name), "SDLC stands for ?", " Software design life cycle", " Software development life cycle", " System design life cycle", "System development life cycle", 2);

            AddQuestionInSubject(subject_id, subject_name, GetNewQuestionNumber(subject_id, subject_name), "SRS stands for ?", " Software requirement specification", " Software requirement solution", " System requirement specification", "none of above", 1);

            AddQuestionInSubject(subject_id, subject_name, GetNewQuestionNumber(subject_id, subject_name), " Software engineering aims at developing ?", " Reliable Software", "Cost Effective Software", " Reliable and cost effective Software", "none of above", 3);
            
            return dt_questions;

        }
    }
}
