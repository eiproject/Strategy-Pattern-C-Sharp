using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualComputer.Models {
  class Notebook : Computer {
    internal override void View() { }
    internal override void Specification() { }
    internal Notebook() {
      cursorBehavior = new UsingTouchpad();
      powerBehavior = new UsingBattery();
      typingBehavior = new UsingBuiltInKeyboard();
    }
  }
}
