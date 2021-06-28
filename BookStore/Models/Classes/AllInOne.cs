using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualComputer.Models {
  class AllInOne : Computer {
    internal override void View() { }
    internal override void Specification() { }
    internal AllInOne() {
      cursorBehavior = new UsingMouse();
      powerBehavior = new NotUsingBattery();
      typingBehavior = new UsingExternalKeyboard();
    }
  }
}
