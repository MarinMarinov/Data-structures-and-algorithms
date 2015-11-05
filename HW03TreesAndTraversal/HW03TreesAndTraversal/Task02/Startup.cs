using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Task02
{
    public class Startup
    {
        static void Main()
        {
            DirectoryInfo path = new DirectoryInfo("C:\\Windows");
            Traverse(path);
        }

        public static void Traverse(DirectoryInfo dir)
        {
            try
            {
                List<FileInfo> exeFiles = dir.GetFiles().Where(f => f.Extension == ".exe").ToList();

                foreach (var file in exeFiles)
                {
                    Console.WriteLine(file.FullName + file.Extension);
                }
            }
            catch(Exception)
            {
                Console.WriteLine("Access to folder is denied!");
                return;
            }

            foreach (var subDir in dir.GetDirectories())
            {
                Traverse(subDir);
            }
        }
    }
}
