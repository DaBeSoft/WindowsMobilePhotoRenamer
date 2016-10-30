using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoRenamer
{
    public class Program
    {
        private static int count = 0;

        public static void Main(string[] args)
        {
            var path = string.Empty;
            if (args.Length > 0)
                path = args[0];

            while (string.IsNullOrWhiteSpace(path) || !Directory.Exists(path))
            {
                Console.WriteLine("Enter Path: ");
                path = Console.ReadLine();
            }
            
            DoDirectoryRecursiv(path);

            Console.WriteLine($"renamed {count} files");
            Console.ReadLine();
        }

        private static void DoDirectoryRecursiv(string path)
        {
            var dirs = Directory.GetDirectories(path);
            foreach (var dir in dirs)
            {
                DoDirectoryRecursiv(dir);
            }

            Console.WriteLine($"Doing Directory {path}");

            var jpgFiles = Directory.GetFiles(path, "*.jpg");
            Console.WriteLine($"Found {jpgFiles.Length} jpgs in dir");

            int x = 0;

            foreach (var jpgFile in jpgFiles)
            {
                var nameOfDng = Path.Combine(Path.GetDirectoryName(jpgFile), Path.GetFileNameWithoutExtension(jpgFile) + "__highres.dng");
                if (File.Exists(nameOfDng))
                {
                    Console.WriteLine($"Found Dng for {jpgFile}, renaming...");
                    var moveTo = Path.Combine(Path.GetDirectoryName(jpgFile), Path.GetFileNameWithoutExtension(jpgFile) + ".dng");

                    File.Move(nameOfDng, moveTo);

                    x++;
                }
                //WP_20161028_00_25_08_Raw.jpg
                //WP_20161028_00_25_08_Raw__highres.dng
            }

            Console.WriteLine($"renamed {x} files in dir");
            count += x;
        }
    }
}