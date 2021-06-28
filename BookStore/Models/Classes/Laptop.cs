using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualComputer.Models {
  class Laptop : Computer {
    internal override void View() {
      Console.WriteLine("Laptop unique view");
    }
    internal override void Specification() {
      Console.WriteLine("Laptop unique specification");
    }

    internal Laptop() {
      View();
      Specification();
      cursorBehavior = new UsingTouchpad();
      powerBehavior = new UsingBattery();
      typingBehavior = new UsingBuiltInKeyboard();
    }
  }
}
