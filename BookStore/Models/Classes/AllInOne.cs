using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualComputer.Models {
  class AllInOne : Computer {
    internal override void View() {
      Console.WriteLine("All In One unique view");
    }
    internal override void Specification() {
      Console.WriteLine("All In One unique specification");
    }
    internal AllInOne() {
      View();
      Specification();
      cursorBehavior = new UsingMouse();
      powerBehavior = new NotUsingBattery();
      typingBehavior = new UsingExternalKeyboard();
    }
  }
}
