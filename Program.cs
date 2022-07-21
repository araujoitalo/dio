using System;
using dio.src.Entities;

namespace dio
{
    class Program
    {
        static void Main(string[] args)
        {
         
           Knight arus = new Knight("Arus", 42, "Knight", 749, 72);
           Ninja wedge = new Ninja("Wedge", 42, "Ninja", 574, 89);
           WhiteWizard jennica = new WhiteWizard("Jennica", 42, "White Wizard", 601, 482);
           BlackWizard topapa = new BlackWizard("Topapa", 42, "Black Wizard", 385, 641);
           
           Console.WriteLine(arus.ToString());
           Console.WriteLine(arus.Attack());
           Console.WriteLine(arus.Attack(1));
           Console.WriteLine(arus.Attack(4));

           Console.WriteLine(wedge.ToString());
           Console.WriteLine(wedge.Attack());
           Console.WriteLine(wedge.Attack(3));
           Console.WriteLine(wedge.Attack(10));

           Console.WriteLine(jennica.ToString());
           Console.WriteLine(jennica.Attack());
           Console.WriteLine(jennica.Attack(7));
           Console.WriteLine(jennica.Attack(15));

           Console.WriteLine(topapa.ToString());
           Console.WriteLine(topapa.Attack());
           Console.WriteLine(topapa.Attack(13));
           Console.WriteLine(topapa.Attack(20));
       
        }
    }
}
