using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualComputer.Models {
  class Tablet : Computer {
    internal override void View() {
      Console.WriteLine("Tablet unique view");
    }
    internal override void Specification() {
      Console.WriteLine("Tablet unique specification");
    }
    internal Tablet() {
      View();
      Specification();
      cursorBehavior = new UsingTouchScreen();
      powerBehavior = new UsingBattery();
      typingBehavior = new UsingTouchKeyboard();
    }
  }
}
