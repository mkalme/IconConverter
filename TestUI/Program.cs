using System;
using System.IO;
using System.Drawing;
using IconConverter;

namespace TestUI {
    class Program {
        private static readonly string Path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        static void Main(string[] args){
            File.WriteAllBytes($"{Path}\\_64pxKey.ico", IconConvert.IconToByteArray(Image.FromFile(@"D:\\_64pxKey.png"), new Size(64, 64)));

            Console.ReadLine();
        }
    }
}
