using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualComputer.Models {
  class Notebook : Computer {
    internal override void View() {
      Console.WriteLine("Notebook unique view");
    }
    internal override void Specification() {
      Console.WriteLine("Notebook unique specification");
    }
    internal Notebook() {
      View();
      Specification();
      cursorBehavior = new UsingTouchpad();
      powerBehavior = new UsingBattery();
      typingBehavior = new UsingBuiltInKeyboard();
    }
  }
}
