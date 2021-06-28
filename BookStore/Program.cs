using System;
using VirtualComputer.Models;

namespace VirtualComputer {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Virtual Computer Running!");

      /*Computer razifLaptop = new Laptop();
      razifLaptop.checkCursor();
      razifLaptop.checkPower();
      razifLaptop.checkTyping();*/

      Computer adminComputer = new PersonalComputer();
      adminComputer.checkCursor();
      adminComputer.setCursor(new UsingMouse());
      adminComputer.checkCursor();
    }
  }
}
