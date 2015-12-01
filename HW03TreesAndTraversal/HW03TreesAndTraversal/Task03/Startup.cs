namespace Task04
{
    using System;
    using System.IO;

    public class Startup
    {
        private const string RootFolderPath = "C:\\Windows\\Web";

        public static void Main()
        {
            DirectoryInfo dir = new DirectoryInfo(RootFolderPath);

            var rootFolder = new MyFolder("RootFolder");

            MakeFileSystem(dir, rootFolder);

            FolderPrint(rootFolder, 0);
        }

        private static void FolderPrint(MyFolder currentFolder, int space)
        {
            Console.WriteLine(new string('-', space) + currentFolder.Name);

            foreach (var file in currentFolder.Files)
            {
                Console.WriteLine(new string('-', space + 3) + file.Name);
            }

            foreach (var folder in currentFolder.SubFolders)
            {
                FolderPrint(folder, space + 3);
            }
        }

        private static void MakeFileSystem(DirectoryInfo dir, MyFolder currentFolder)
        {
            foreach (FileInfo file in dir.GetFiles())
            {
                var newFile = new MyFile(file.Name, file.Length);
                currentFolder.Files.Add(newFile);
            }

            foreach (DirectoryInfo subDir in dir.GetDirectories())
            {
                var newDirectory = new MyFolder(subDir.Name);
                currentFolder.SubFolders.Add(newDirectory);

                MakeFileSystem(subDir, newDirectory);
            }
        }
    }
}
