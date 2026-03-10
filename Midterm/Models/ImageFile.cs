using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class ImageFile : File
    {
        public Image Image { get; set; }
        public ImageFile(string name, string extension, Image image)
        {
            Name = name;
            Extension = extension;
            Image = image;
        }

        public void Read()
        {
            Console.WriteLine($"Viewing file {Name}.{Extension}...");
        }
        public void Write(Image image)
        {
            Console.WriteLine($"Image added to {Name}.{Extension}...");
        }
    }
}
