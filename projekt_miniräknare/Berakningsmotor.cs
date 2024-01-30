using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miniräknare
{
    static class Berakningsmotor
    {
        public static double Berakna(string input)
        {
            // Dela upp uttrycket i tal och operatorer
            string[] delar = input.Split(' ');

            double tal1 = double.Parse(delar[0]);
            string operatorn = delar[1];
            double tal2 = double.Parse(delar[2]);

            // Utför beräkningen beroende på operatorn
            switch (operatorn)
            {
                case "+":
                    return tal1 + tal2;
                case "-":
                    return tal1 - tal2;
                case "*":
                    return tal1 * tal2;
                case "/":
                    if (tal2 == 0)
                        throw new DivideByZeroException("Det går inte att dividera med noll.");
                    return tal1 / tal2;
                case "^":
                    return Math.Pow(tal1, tal2);

                default:
                    throw new ArgumentException("Ogiltig operator: " + operatorn);
            }
        }
    }
}
