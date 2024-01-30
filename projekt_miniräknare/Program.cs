using System;
using System.IO;


namespace projekt_miniräknare 

{
    class Program
    {
        static void Main()
        {
            string filnamn = "berakningar.txt";
            Miniraknare miniraknare = new Miniraknare(filnamn);
            miniraknare.Kora();
        }
    }


}
