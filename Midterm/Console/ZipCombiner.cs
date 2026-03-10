using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace ConsoleApp
{
    public class ZipCombiner
    {
        public Models.ZipFile CombineZips(Models.ZipFile zip1, Models.ZipFile zip2)
        {

            Console.WriteLine($"Number of zipped files in file 1: {zip1.Files.Count}");
            Console.WriteLine($"Number of zipped files in file 2: {zip2.Files.Count}");

            List<Models.File> files = new List<Models.File>();
            files.AddRange(zip1.Files);
            files.AddRange(zip2.Files);

            Console.WriteLine($"Files in combined zip:");
            foreach (Models.File file in files)
            {
                Console.WriteLine(file.Name + "." + file.Extension);
            }

            return new Models.ZipFile("output", "zip", files);
        }
    }
}
