using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace StringChanger
{
    class Program
    {
        static void Main()
        {
            string path = Console.ReadLine();

            Changer(path, "Hi!", "Bye!", "*.txt");
        }

        static void Changer(string path, string oldString, string newString, string fileType)
        {
            if (Directory.Exists(path))
            {
                var subDirectories = Directory.GetDirectories(path);

                if (subDirectories.Length > 0)
                {
                    foreach (var subDirectory in subDirectories)
                    {
                        Changer(subDirectory, oldString, newString, fileType);
                    }
                }

                var files = Directory.GetFiles(path, fileType);

                foreach (var file in files)
                {
                    string text = File.ReadAllText(file);
                    
                    if (text.Contains(oldString))
                    {
                        text = text.Replace(oldString, newString);
                        File.WriteAllText(file, text);

                        using (StreamWriter sw = File.AppendText("log.txt"))
                        {
                            sw.WriteLine("Replace in file: {0}", Path.GetFileName(file));
                            sw.WriteLine(text);
                            sw.WriteLine();
                        }
                    }

                    
                }
            }
            else
            {
                Console.WriteLine("Directory doesn`t exist.");
            }
        }
    }
}
