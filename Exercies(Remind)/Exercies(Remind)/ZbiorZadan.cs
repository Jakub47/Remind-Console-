using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercies_Remind_
{
    class ZbiorZadan
    {
        public List<Zadanie> Zadania { get; set; }


        public ZbiorZadan()
        {
            Zadania = new List<Zadanie>()
            {
                new Zadanie("Program przeliczający temperaturę w stopniach Celsjusza na temperaturę w stopniach Fahrenheita","Podaj temperature w stopniach Celsjusza"),
                new Zadanie("Program, który oblicza deltę dla równania kwadratowego ax2 +bx+c=0","Podaj współczynniki a, b oraz c.(Odzielone spacja)"),
                new Zadanie("Program, który oblicza wskaźnik masy ciała BMI.","Podanj wage w kilogramach oraz wzrost w metrach (Odzielone spacja)")
            };
        }

        public void PobierzDaneIObliczwynik(int numerZadania)
        {
            var zadanie = Zadania.ElementAt(numerZadania);
            zadanie.NapiszTresc();
            zadanie.PoprosODane();
            var elements = Console.ReadLine().Split(' ').ToList();
            zadanie.WprowadzLiczby(elements.Select(float.Parse).ToList());

        }
    }
}
