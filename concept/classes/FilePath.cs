using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace concept.classes
{
   public static class FilePath
    {
        public static string fileLoc = @"c:\BSSE\";
        public static string fileLoc1 = @"c:\BSCS\";
        public static string fileLoc2 = @"c:\MSCS\";
        public static string fileLoc3 = @"c:\MSSE\";
       public static string GetFilePath(string subject)
        {
            if (subject=="BSSE")
            {
                return fileLoc;
                
            }
            else if (subject=="BSCS")
            {
                return fileLoc1;
            }
            else if (subject == "MSCS")
            {
                return fileLoc2;
                
            }
            else if (subject=="MSSE")
            {
                return fileLoc3;
            }
            else 
           
                return "";
                
            

	

        }
    }
}
