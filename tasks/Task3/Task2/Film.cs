using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Film
    {
        private int erscheinungsJahr;
        private string titel;
        private List<Schauspieler> lst_schauspieler = new List<Schauspieler>();
        private List<Kameramann> lst_kameramann = new List<Kameramann>();

        /// <summary>
        /// Erstellt ein Filmobjekt mir titel und Jahr
        /// </summary>
        /// <param name="jahr"></param>
        /// <param name="title"></param>
        public Film(int jahr, string title)
        {
            Jahr = jahr;
            UpdateTitle(title);
        }

        /// <summary>
        /// Erstellt ein Filmobjekt mit Schauspieler, Jahr und Titel
        /// </summary>
        /// <param name="s"></param>
        /// <param name="j"></param>
        /// <param name="t"></param>
        public Film(Schauspieler s, int j, string t)
        {
            lst_schauspieler.Add(s);
            Jahr = j;
            UpdateTitle(t);
        }
        
        public List<Schauspieler> GetSchauspieler() => lst_schauspieler;

        public List<Kameramann> GetKammeramaenner() => lst_kameramann;

        public int Jahr
        {
            get
            {
                return erscheinungsJahr;
            }
            set
            {
                ErrorHandling.CheckForError(value);
                erscheinungsJahr = value;
            }
        }

        public string Titel => titel;

        public void UpdateTitle(string title)
        {
            ErrorHandling.CheckForError(title);
            this.titel = title;
        }


        /// <summary>
        /// Fügt dem Film einen Schauspieler hinzu
        /// </summary>
        /// <param name="schauspieler"></param>
        public void AddSchauspieler(Schauspieler schauspieler)
        {
            lst_schauspieler.Add(schauspieler);
        }

        /// <summary>
        /// Fügt dem Film einen Kameramann hinzu
        /// </summary>
        /// <param name="kameramann"></param>
        public void AddKameramann(Kameramann kameramann)
        {
            lst_kameramann.Add(kameramann);
        }
    }
}
