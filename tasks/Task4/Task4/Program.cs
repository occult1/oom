using System;
using System.Reactive.Subjects;
using System.Reactive.Linq;
using System.Linq;

namespace Task4
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
                    new Schauspieler("The Rock"),
                    new Kameramann("Kam")
                };

                Task4.Subject.Run(mycrew);

                //Subject<ICrewmitglieder> sub = new Subject<ICrewmitglieder>();
                //var subscription = sub.Subscribe(
                //         // Vorlage wie etwas ausgegeben wird
                //         x => Console.WriteLine("Rolle: {0}\t Name: {1}", x.Rolle, x.Name),
                //         // wenn es kein element mehr gibt
                //         () => Console.WriteLine("Das war die Crew."));
               
                //sub.OnNext(s);

                //sub.OnNext(new Kameramann("Paul"));

                //sub.OnNext(new Schauspieler("The Rock"));

                //sub.OnNext(new Kameramann("Kam"));

                //sub.OnCompleted();
                //subscription.Dispose();



                Serialization.Run(mycrew);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error:{ex}");
            }
        }
    }
}
