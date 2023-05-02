using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pre.Streams.Introduction.Cons
{
    internal class App
    {

        public void ReadFile(string fileLocation)
        {
            try
            {
                using (StreamReader streamReader = new StreamReader(fileLocation, Encoding.Default, true))
                {
                    Console.WriteLine(streamReader.ReadToEnd());
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file was not found");
            }
            
        }

        public bool WriteFile(string fileLocation, string content)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(fileLocation, true))
                {
                    writer.Write(content);
                    return true;
                }
            }
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("De map bestaat niet op deze computer");
            }
            catch (IOException)
            {
                Console.WriteLine($"Het bestand {fileLocation} kan niet weggeschreven worden.\n");
            }
            catch (Exception)
            {
                Console.WriteLine("Er is een fout opgetreden");
            }

            return false;
        }
        public void Run()
        {
            ReadFile(@"c:\Howest\bestand.txt");
            WriteFile(@"c:\Howest\bestand.txt", "ghi");
        }
    }
}
