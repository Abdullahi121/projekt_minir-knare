using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projekt_miniräknare
{
    class Miniraknare
    {
        private string filnamn;

        public Miniraknare(string filnamn)
        {
            this.filnamn = filnamn;
        }

        public void Kora()
        {
            while (true)
            {
                Console.Write("Ange uttryck som tal 1 (+,-,*,/, ^,) tal 2\n(eller 'exit' för att avsluta): ");
                string input = Console.ReadLine();

                if (input.ToLower() == "exit")
                    break;

                try
                {
                    double resultat = Berakningsmotor.Berakna(input);
                    Console.WriteLine("Resultat: " + resultat);

                    // Spara till fil
                    string berakning = $"{input} = {resultat}";
                    SparaTillFil(berakning);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Felaktigt uttryck. Felmeddelande: " + ex.Message);
                }
            }
        }

        private void SparaTillFil(string text)
        {
            using (StreamWriter writer = File.AppendText(filnamn))
            {
                writer.WriteLine(text);
            }
        }
    }
}
