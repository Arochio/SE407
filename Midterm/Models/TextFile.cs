using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class TextFile : File
    {
        public string Text { get; set; }
        public TextFile(string name)
        {
            Name = name;
            Extension = "txt";
        }
    }
}
