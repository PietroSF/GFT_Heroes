using System;
using Heroes.src.entities;

namespace Heroes
{
  class Program
  {
    static void Main(string[] args)
    {
      Hero Arus = new Hero("Arus", "Knight", 1, "Sword of Slicing");
      Villain Maleficus = new Villain("Maleficus", "Vampire", 99, "Orb of Hero-killing");
      Hero Jennica = new Hero("Jennica", "Mage", 1, "Staff of Spellcasting");
      Console.WriteLine(Maleficus);
      Console.WriteLine(Arus.Attack(Maleficus));
      Console.WriteLine(Maleficus.Attack(Arus));
    }
  }
}