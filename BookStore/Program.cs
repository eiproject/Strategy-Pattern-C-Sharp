using System;
using System.Runtime.CompilerServices;
using VirtualComputer.Models;

[assembly: InternalsVisibleTo("UnitTesting")]

namespace VirtualComputer {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Virtual Computer Running!");

      /*Computer razifLaptop = new Laptop();
      razifLaptop.checkCursor();
      razifLaptop.checkPower();
      razifLaptop.checkTyping();*/

      Computer adminComputer = new PersonalComputer();
      adminComputer.Display();
      string c1 = adminComputer.checkCursor();
      adminComputer.setCursor(new UsingMouse());
      string c2 = adminComputer.checkCursor();
    }
  }
}
