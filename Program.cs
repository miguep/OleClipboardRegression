using System;
using System.Windows; // Use WPF
//using System.Windows.Forms; // Use Winforms

namespace ClipboardRegressionConsole
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Clipboard.SetData(DataFormats.UnicodeText, "abc");
            Console.WriteLine("Hello World!");
        }
    }
}
