using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergePDFList
{
    public class PdfFile
    {
        public ulong ID { get; set; }
        public string FullName { get; set; }
        public string Name { get; set; }
        public long Length { get; set; }
        public DateTime CreationTime { get; set; }

        public DateTime LastAccessTime { get; set; }

        public DateTime LastWriteTime { get; set; }
        
        public string FilePath {get;set;}
        
        //public FileInfo test { get; set; }

        public PdfFile(string fName,ulong id)
        {
            var fi = new FileInfo(fName);
            this.FullName = fi.FullName;
            //this.Name = System.IO.Path.GetFileName(fName);
            this.Name = fi.Name;
            this.Length = fi.Length;
            this.CreationTime = fi.CreationTime;
            this.LastAccessTime = fi.LastAccessTime;
            this.LastWriteTime = fi.LastWriteTime;
            this.FilePath = System.IO.Path.GetDirectoryName(fName);
            this.ID = id;
        }
      
    }
}
