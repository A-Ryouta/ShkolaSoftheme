using System;
using System.IO;
using System.IO.Compression;
using System.Threading;

namespace Archiver
{
    class Program
    {
        static string path;

        static void Main()
        {
            path = Console.ReadLine();
            
            Processing(path);
        }

        static void Processing(string path)
        {
            if (Directory.Exists(path))
            {
                var directory = new DirectoryInfo(path);
                var files = directory.GetFiles("*", SearchOption.AllDirectories);

                for (var i = 0; i < files.Length; i++)
                {
                    Thread thread = new Thread(Archivator);

                    thread.Start(files[i]);
                    thread.Join();
                }
            }
            else
            {
                Console.WriteLine("Directory doesn`t exist.");
            }
        }

        static void Archivator(object o)
        {
            var file = o as FileInfo;
            var resultPath = file.FullName.Replace(file.Extension, ".zip");            

            using (FileStream fs = new FileStream(resultPath, FileMode.Create))
            {
                using (ZipArchive archive = new ZipArchive(fs, ZipArchiveMode.Update))
                {
                    archive.CreateEntry(file.Name);                    
                }
            }                
        }
    }
}
