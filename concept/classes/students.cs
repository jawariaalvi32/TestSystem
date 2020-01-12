using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace concept.classes
{
   public class students
    {
        string name;
        string email;

        string qualification;
        string mob_no;
        int age;
        string subject;
        public students(string name, string email, string qualification,string mob_no, int age, string subject)
        {
            this.name = name;
            this.email = email;
            this.qualification = qualification;
            this.mob_no = mob_no;
            this.age = age;
            this.subject = subject;
            

        }
        


    }
}
