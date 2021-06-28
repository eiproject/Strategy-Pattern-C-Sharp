using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualComputer.Models {
  class Laptop : Computer {
    internal override void View() { }
    internal override void Specification() { }

    internal Laptop() {
      cursorBehavior = new UsingTouchpad();
      powerBehavior = new UsingBattery();
      typingBehavior = new UsingBuiltInKeyboard();
    }
  }
}
