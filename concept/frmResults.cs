using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using concept.classes;

namespace concept
{
    public partial class frmResults : Form
    {
        string name;
        string email;
        string qualification;
        string mobile;
        string subject;
        int age;
        double ObtainedMarks;
        double TotalMarks;
        double percentage;
        // int percentage = (ObtainedMarks / TotalMarks) * 100;
        string completepath;
        double correctAns;



        public frmResults()
        {
            InitializeComponent();
        }
        public frmResults(string name,string email,string qualification,string mobile,string subject,int age,double ObtainedMarks,double TotalMarks,double percentage, double correctAns)

        {
            InitializeComponent();
            this.name = name;
            this.email=email;
            this.qualification = qualification;
            this.mobile = mobile;
            this.subject = subject;
            this.age = age;
            this.ObtainedMarks = ObtainedMarks;
            this.TotalMarks = TotalMarks;
            this.correctAns=correctAns;

        
           
        }
        private void frmResults_Load(object sender, EventArgs e)
        {
            lbl_name.Text = "name : "+ name;
            lbl_email.Text = "email: "+email;
            lbl_qualification.Text = "qualification: "+qualification;
            lbl_moile.Text = "mobile: "+mobile;
            lbl_subject.Text ="subject: "+ subject;
            lbl_age.Text ="age: "+ age.ToString();
            lbl_obtainedmarks.Text ="obtain marks: "+ ObtainedMarks.ToString();
            lbl_totalmarks.Text = "total marks: "+TotalMarks.ToString();
            percentage = (ObtainedMarks / TotalMarks) * 100;
            lbl_percentage.Text = "percentage: " + percentage.ToString();
            lbl_correct_answer.Text = "correct answers are:" + correctAns;
           
            string FilePAth = FilePath.GetFilePath(subject);
            string filename = mobile + "-" + subject + "-" + DateTime.Now.ToString("dd-MMM-yyyy") + ".txt";
           completepath = FilePAth + filename;
          
              if (!Directory.Exists(FilePAth))
              {
                  {
                      Directory.CreateDirectory(FilePAth);//directory folder create hora hai yahn //
                  }
              }
            //*******NOW CREATE THE FILE WHO HAVE RESULTS
              
              StringBuilder sb = new StringBuilder();
              sb.Append("NAME: "+name);
              sb.AppendLine();
              sb.Append("EMAIL: "+email);
              sb.AppendLine();
              sb.Append("QUALIFICATION:"+qualification);
              sb.AppendLine();
              sb.Append("MOBILE NUMBER: "+mobile);
              sb.AppendLine();
              sb.Append("AGE: " + age);
              sb.AppendLine();
              sb.Append("SUBJECT: " + subject);
              sb.AppendLine(); 
              sb.Append("OBTAINED MARKS " + ObtainedMarks);
              sb.AppendLine();
              sb.Append("TOTAL MARKS" +TotalMarks);
              sb.AppendLine();
              sb.Append("PERCENTAGE: " + percentage);
              sb.AppendLine();
              File.WriteAllText(Path.Combine(FilePAth, filename), sb.ToString());

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lbl_age_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
   

           
            Process Proc = new Process();

            
            Proc.StartInfo.FileName = completepath;
            Proc.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FRM_MAIN OBJ = new FRM_MAIN();
            OBJ.Show();
            this.Hide();
        }
    }
}
