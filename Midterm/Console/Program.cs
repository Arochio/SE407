using Models;

namespace ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            TextFile txtFile = new TextFile("CoolTextDocument");
            Image img = new Image();
            Image img2 = new Image();
            ImageFile imgFile = new ImageFile("CoolImage", "png", img);

            txtFile.Write("Hello!");
            Console.WriteLine("\n");
            txtFile.Read();
            Console.WriteLine("\n");
            imgFile.Write(img2);
            Console.WriteLine("\n");
            imgFile.Read();

            List<Models.File> files1 = new List<Models.File>();
            files1.Add(txtFile);
            List<Models.File> files2 = new List<Models.File>();
            files2.Add(imgFile);

            Models.ZipFile zip1 = new Models.ZipFile("newzipfile1", "zip", files1);
            Models.ZipFile zip2 = new Models.ZipFile("newzipfile2", "zip", files2);

            ZipCombiner zipcombo = new ZipCombiner();

            Models.ZipFile combinedZip = zipcombo.CombineZips(zip1, zip2);

            combinedZip.Read();
        }
    }
}
