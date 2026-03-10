using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaces;

namespace Models
{
    internal class Book : IFile
    {
        public string Name { get; set; }
        public string? Content { get; set; }
        public void Read()
        {
            Console.WriteLine($"Reading book called '{Name}': {Content}");
        }
        public void Write(string text)
        {
            Console.WriteLine($"Writing book called '{Name}': '{text}, the end.'");
            Content = text + ", the end.";
        }
        public Book(string name)
        {
            Name = name;
        }
    }
}
