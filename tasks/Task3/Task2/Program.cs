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
                var s = new Schauspieler("Keanu Reeves");
                var a = new Film(1999, "Matrix");
                //a.AddSchauspieler(s);
               // Console.WriteLine(a.Titel);
                //Console.WriteLine(a.Jahr);
               // var a_schauspieler = a.GetSchauspieler();
                //a.UpdateTitle("The Sixth Sense");
                //Console.WriteLine(a.Titel);
               // var b = new Film(-1, "");

                var mycrew = new ICrewmitglieder[]
                    {
                    s,
                    new Kameramann("Paul"),
                };

                Serialization.Run(mycrew);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error:{ex}");
            }
        }
    }
}
