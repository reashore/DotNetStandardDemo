using DotNetStandardDemo.StandardLibrary;
using static System.Console;

namespace DotNetStandardDemo.FrameworkConsole
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            const string message = "This line is printed by a .Net Framweork console application using a .Net Standard library.";
            Printer.Print(message);

            ReadKey();
        }
    }
}
