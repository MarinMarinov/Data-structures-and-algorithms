using System.Collections.Generic;

namespace Task04
{
    public class MyFolder
    {
        private ICollection<MyFile> files;
        private ICollection<MyFolder> subFolders;

        public MyFolder(string name)
        {
            this.Name = name;
            this.Files = new List<MyFile>();
            this.SubFolders = new List<MyFolder>();
        }

        public MyFolder(string name, MyFile[] files, MyFolder[] subFolders)
        {
            this.Name = name;
            this.Files = files;
            this.SubFolders = subFolders;
        }

        public string Name { get; set; }

        public ICollection<MyFile> Files
        {
            get { return this.files; }
            set { this.files = value; }
        }

        public ICollection<MyFolder> SubFolders
        {
            get { return this.subFolders; }
            set { this.subFolders = value; }
        }

        public long GetFileSize()
        {
            long fileSize = 0;

            foreach (var file in this.Files)
            {
                fileSize += file.Size;
            }

            foreach (var folder in this.SubFolders)
            {
                fileSize += folder.GetFileSize();
            }

            return fileSize;
        }
    }
}