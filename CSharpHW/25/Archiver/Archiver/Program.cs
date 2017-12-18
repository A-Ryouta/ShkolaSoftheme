using System;
using System.IO;
using System.IO.Compression;

namespace Archiver
{
    class Program
    {
        static void Main()
        {
            string path = Console.ReadLine();
            
            Archive(path);
        }

        static void Archive(string path)
        {
            if (Directory.Exists(path))
            {
                var subDirectories = Directory.GetDirectories(path);

                if (subDirectories.Length > 1)
                {
                    for(var i = 1; i < subDirectories.Length; i++)
                    {
                        Archive(subDirectories[i]);
                    }
                }

                var files = Directory.GetFiles(path);

                for(var i = 0; i < files.Length; i++)
                {
                    string resultPath = path + @"\" + Path.GetFileNameWithoutExtension(files[i]) + ".zip";
                    string result = @"d:\zips\result.zip";
                    ZipFile.CreateFromDirectory(path, result);
                }
            }
            else
            {
                Console.WriteLine("Directory doesn`t exist.");
            }
        }
    }
}
