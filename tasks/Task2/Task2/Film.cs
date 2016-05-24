using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Film
    {
        private int erscheinungsJahr;
        private string titel;

        public Film(int jahr, string title)
        {
            Jahr = jahr;
            UpdateTitle(title);
        }

        public int Jahr
        {
            get
            {
                return erscheinungsJahr;
            }
            set
            {
                if (value < 0) throw new Exception("Upps");
                erscheinungsJahr = value;
            }
        }

        public string Titel
        {
            get
            {
                return titel;
            }            
        }

        public void UpdateTitle(string title)
        {
            if (string.IsNullOrWhiteSpace(title)) throw new Exception("Titel darf nicht leer sein");
            this.titel = title;
        }

    }
}
