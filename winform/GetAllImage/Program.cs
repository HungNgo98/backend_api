using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetAllImage
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"D:\anh\image\New folder");
            FileInfo[] imageFiles = dir.GetFiles("*.jpg");
            Console.WriteLine("Found {0} *.jpg files\n", imageFiles.Length);
            foreach (FileInfo f in imageFiles)
            {
                Console.WriteLine("File name: {0}", f.Name);
                Console.WriteLine("File size: {0}", f.Length);
                Console.WriteLine("Creation: {0}", f.CreationTime);
                Console.WriteLine("Attributes: {0}", f.Attributes);
            }
            Console.ReadKey();
        }
      
    }
}
