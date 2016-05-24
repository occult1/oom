using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Kameramann : ICrewmitglieder
    {
        private string name;
        private myEnums.Rolle rolle;

        public string Name => name;

        public myEnums.Rolle Rolle => rolle;

        public Kameramann(string name)
        {
            ErrorHandling.CheckForError(name);
            this.name = name;
            rolle = myEnums.Rolle.Kameramann;
        }


    }
}
