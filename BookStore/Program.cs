using System;
using VirtualComputer.Models;

namespace VirtualComputer {
  class Program {
    static void Main(string[] args) {
      Console.WriteLine("Virtual Computer Running!");

      Computer RazifLaptop = new Laptop();
      RazifLaptop.setCursor();
    }
  }
}
