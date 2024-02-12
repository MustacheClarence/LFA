using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using LFA_HT2;

namespace LFA_HT2
{
    internal class ht2
    {
        public void ReconocimientoDePlacas() {
            string patron = @"^[P|C|O|M|A]\d{3}[A-Z]{3}$";

            Console.WriteLine("Ingrese la placa");
            var text = Console.ReadLine();
            Match match = Regex.Match(text, patron);
            if (match.Success)
            {
                Console.WriteLine("Placa Valida");
            }
            else {Console.WriteLine("Placa No Valida"); }
            Console.ReadLine();
        }

        public void ReconocimientoDeFechas()
        {
            string patron = @"^\d{4}/(0[1-9]|1[0-2])/(0[1-9]|[12][0-9]|3[01]) (?:[01][0-9]|2[0-3]):(?:[0-5][0-9]):(?:[0-5][0-9])$";

            Console.WriteLine("Ingrese la fecha");
            var text = Console.ReadLine();
            Match match = Regex.Match(text, patron);
            if (match.Success)
            {
                Console.WriteLine("Fecha Valida");
            }
            else { Console.WriteLine("Fecha No Valida"); }
            Console.ReadLine();
        }

        public void ReconocimientoDeSets() { 
        }
    }
}
