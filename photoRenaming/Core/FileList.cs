using System.IO;

namespace photoRenaming.Core
{
    public class FileList
    {
        public string Name { get; set;}
        public string FullPath { get; set; }
        public string ImageSet { get; set; }
        public FileAttributes Attributes { get; set; }

        public string Rating { get; set; }
    }
}
