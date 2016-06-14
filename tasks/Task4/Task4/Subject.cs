using System; 
using System.Collections.Generic; 
using System.Drawing; 
using System.Linq; 
using System.Reactive.Linq; 
using System.Reactive.Subjects; 
using System.Text; 
using System.Threading; 
using System.Threading.Tasks; 
using static System.Console;
using Task4;


namespace Task4
{
    public static class Subject
    { 
         public static void Run(object myCrew)
         {
            try
            {
                var checkForType = myCrew;
                ErrorHandling.CheckforType(checkForType, typeof(ICrewmitglieder[]));

                var myArray = (ICrewmitglieder[])myCrew;
                var source = new Subject<ICrewmitglieder>();


                source
                    .Sample(TimeSpan.FromSeconds(1.5))
                    .Subscribe(x => Console.WriteLine($"Rolle: {x.Rolle}"))
                    ;


                var t = new Thread(() =>
                {
                    var i = 0;
                    while (i < myArray.Length)
                    {
                        Thread.Sleep(2500);
                        source.OnNext(myArray[i]);
                        Console.Write($"Name {myArray[i].Name}\t");
                        i++;
                    }
                });
                t.Start();
            }
            catch (Exception ex)
            {

                Console.WriteLine("Subject.Run: ",ex); 
            }
           
        } 
     } 

}
