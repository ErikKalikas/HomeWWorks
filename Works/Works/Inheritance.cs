using System;
using System.Collections.Generic;
using System.Text;

namespace Works
{
    internal class Inheritance
    {
    }

    class Isik
    {
        public string Nimi;
        public int Vanus;
        
        public Isik(string Nimi, int Vanus)
        {
            Nimi = "Erik";
            Vanus = 17;

            this.Nimi = Nimi;
            this.Vanus = Vanus;
        }
    }

    // Õpetaja pärib klassist Isik (koolon tähistab pärimist)
    public class Õpetaja : Isik
    {
        public string Aine { get; set; }

        public void Õpeta(string Nimi, int Vanus)
        {
            Console.WriteLine($"{Nimi} õpetab ainet: {Aine}.");
        }
    }

    // Õpilane pärib klassist Isik
    public class Õpilane : Isik
    {
        public string Kool { get; set; }
        public int Klass { get; set; }

        public void Õpi()
        {
            Console.WriteLine($"{Nimi} õpib {Kool} {Klass}. klassis.");
        }
    }
}
