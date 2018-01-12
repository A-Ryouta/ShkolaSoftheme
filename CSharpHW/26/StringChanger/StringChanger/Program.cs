using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace StringChanger
{
    class Program
    {
        static string oldString;
        static string newString;

        static void Main()
        {

            var path = Console.ReadLine();

            var fileType = ".txt";
            oldString = "Hi!";
            newString = "Bye!";

            Changer(path, oldString, newString, fileType);
        }

        static void Changer(string path, string oldString, string newString, string fileType)
        {
            if (Directory.Exists(path))
            {
                DirectoryInfo directory = new DirectoryInfo(path);
                var files = directory.GetFiles("*", SearchOption.AllDirectories)
                    .Where(x => x.Extension == fileType);

                Parallel.ForEach(files, new ParallelOptions { MaxDegreeOfParallelism = Environment.ProcessorCount * 2 },
                    file => Change(file));
            }
            else
            {
                Console.WriteLine("Directory doesn`t exist.");
            }
        }

        static void Change(FileInfo file)
        {
            var lines = File.ReadAllLines(file.FullName);
            var logBuffer = string.Empty;

            for (var i = 0; i < lines.Length; i++)
            {
                if (lines[i].Contains(oldString))
                {
                    lines[i] = lines[i].Replace(oldString, newString);
                    logBuffer += "Line #" + (i + 1) + ": " + lines[i] + Environment.NewLine;
                }
            }

            if (!string.IsNullOrEmpty(logBuffer))
            {
                File.WriteAllLines(file.FullName, lines);
               
                using (StreamWriter sw = File.AppendText("log.txt"))
                {
                    sw.WriteLine("Replace {0} for {1} in file: {2}", oldString, newString, file.Name);
                    sw.WriteLine(logBuffer);                    
                }

            }
        }
    }
}
