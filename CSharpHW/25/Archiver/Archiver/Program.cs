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
            
            Archive(path);
        }

        static void Archive(string path)
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
            var pathBuffer = file.FullName;
            var resultPath = pathBuffer.Replace(file.Extension, ".zip");
            ZipFile.CreateFromDirectory(path, resultPath);            
        }
    }
}
