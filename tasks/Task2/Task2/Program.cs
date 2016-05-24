using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var a = new Film(1999, "Matrix");
                Console.WriteLine(a.Titel);
                Console.WriteLine(a.Jahr);
                a.UpdateTitle("The Sixth Sense");
                Console.WriteLine(a.Titel);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error:{ex}");
            }
        }
    }
}
