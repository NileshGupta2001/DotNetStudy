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
