using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercies_Remind_
{
    class Zadanie : IDane
    {
        public string Tresc { get; set; }
        public string Wyswietl { get; set; }
        public List<float> Liczby { get; set; }

        public Zadanie(string tresc,string wyswietl)
        {
            Tresc = tresc;
            Wyswietl = wyswietl;
        }

        public void NapiszTresc()
        {
            Console.WriteLine(this.Tresc);
        }
        
        public void PoprosODane()
        {
            Console.WriteLine(this.Wyswietl);
        }

        public void WprowadzLiczby(List<float> liczby)
        {
            Liczby = liczby;
        }

        public void Oblicz()
        {
            
        }
    }
}
