﻿namespace Task04
{
    public class MyFile
    {
        public MyFile(string name, long size)
        {
            this.Name = name;
            this.Size = size;
        }

        public string Name { get; set; }

        public long Size { get; set; }
    }
}