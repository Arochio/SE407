using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ZipFile : File
    {
        public List<File> Files { get; set; } = new List<File>();
        public string Name { get; set; }
        public string Extension { get; set; }

        public void Read()
        {
            Console.WriteLine($"Number of zipped files: {Files.Count}");
            Console.WriteLine($"Files:");
            foreach (Models.File file in Files)
            {
                Console.WriteLine(file.Name + "." + file.Extension);
            }
        }

        public void Write(File file)
        {
            Console.WriteLine($"Added {file.Name}.{file.Extension} to Zip.");
            Files.Add(file);
        }
        public ZipFile(string name, string extension, List<File> files) 
        { 
            Name = name;
            Extension = extension;
            Files = files;
        }
    }
}
