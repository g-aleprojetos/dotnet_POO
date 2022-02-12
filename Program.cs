using System;
using dotnet_POO.src.Entities;

namespace dotnet_POO
{
  class Program
  {
    static void Main(string[] args)
    {
      Knight arus = new Knight("Arus", 42, "Knight", 469, 749, 72, 72);
      Ninja wedge = new Ninja("Wedge", 42, "Ninja", 292, 574, 89, 89);
      Wizard jennica = new Wizard("Jennica", 42, "White Wizard", 325, 601, 474, 482);
      Wizard topapa = new Wizard("Topapa", 42, "Black Wizard", 106, 385, 611, 641);

      Console.WriteLine(arus);
      Console.WriteLine(wedge);
      Console.WriteLine(jennica);
      Console.WriteLine(topapa);
      Console.WriteLine("");
      Console.WriteLine(arus.Attack());
      Console.WriteLine(arus.Attack(5));
      Console.WriteLine(arus.Attack(10));
      Console.WriteLine("");
      Console.WriteLine(wedge.Attack());
      Console.WriteLine(wedge.Attack(5));
      Console.WriteLine(wedge.Attack(10));
      Console.WriteLine("");
      Console.WriteLine(jennica.Attack());
      Console.WriteLine(jennica.Attack(5));
      Console.WriteLine(jennica.Attack(10));
      Console.WriteLine("");
      Console.WriteLine(topapa.Attack());
      Console.WriteLine(topapa.Attack(5));
      Console.WriteLine(topapa.Attack(10));
    }
  }
}
