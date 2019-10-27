using DotNetStandardDemo.StandardLibrary;
using static System.Console;

namespace DotNetStandardDemo.CoreConsole
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        public static void Main()
        {
            const string message = "This line was printed by a .Net Core console application using a .Net Standard library.";
            Printer.Print(message);

            ReadKey();
        }
    }
}
