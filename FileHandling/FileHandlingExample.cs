using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    internal class FileHandlingExample
    {
        public string FilePath = "E://Study.txt";
        public void ReadFile()
        {
            FileStream fs = new FileStream(FilePath, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string FileContent=sr.ReadToEnd();
            Console.WriteLine(FileContent);
           
        }

        public void WriteFile()
        {

            try
            {


                FileStream fs = new FileStream(FilePath, FileMode.Append, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                string sr = Console.ReadLine();
                sw.WriteLine(sr);
                sw.Flush();
                sw.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
