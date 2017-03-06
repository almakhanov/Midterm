using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    
    class Program
    {

        static void Main(string[] args)
        {
            // write in the console just "abcd" without commas
            string name;
            name = Console.ReadLine();
            DirectoryInfo fsi = new DirectoryInfo(@"D:\" + name);
            FileSystemInfo[] fi = fsi.GetFileSystemInfos();

            string line = "";

            
            for(int i = 0; i < fi.Length; i++)
            {
                using (FileStream fs = new FileStream(fi[i].FullName, FileMode.Open, FileAccess.Read))
                {
                    using(StreamReader sr = new StreamReader(fs))
                    {
                        while ((line = sr.ReadLine()) != null)
                        {
                             for(int j = 0; j < line.Length; j++)
                            {
                                if(line[j] == 'a' && line[j+1] == 'b' && line[j+2] == 'c' && line[j+3] == 'd')
                                {
                                    Console.WriteLine(fi[i].Name);
                                    Console.ReadKey();
                                    break;
                                }
                            }
                            
                        }
                        
                    }
                }
            }

            

        }
    }
}
