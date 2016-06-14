using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Schauspieler : ICrewmitglieder
    {
        private myEnums.Rolle rolle;
        private string name;

        public string Name => name;

        public myEnums.Rolle Rolle => rolle;

        public Schauspieler(string name)
        {
            ErrorHandling.CheckForError(name);
            this.name = name;
            this.rolle = myEnums.Rolle.Schauspieler;
        }
    }
}
