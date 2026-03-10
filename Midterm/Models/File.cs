using Interfaces;

namespace Models
{
    public class File : IFile
    {
        public string Name { get; set; }
        public string Extension { get; set; }

        public void Read()
        {
            Console.WriteLine($"Reading file {Name}.{Extension}...");
        }

        public void Write(string text)
        {
            Console.WriteLine($"Writing '{text}' to {Name}.{Extension}...");
            Console.WriteLine("Write Successful");
        }
    }
}
