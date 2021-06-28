using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualComputer.Models {
  class Tablet : Computer {
    internal override void View() { }
    internal override void Specification() { }
    internal Tablet() {
      cursorBehavior = new UsingTouchScreen();
      powerBehavior = new UsingBattery();
      typingBehavior = new UsingTouchKeyboard();
    }
  }
}
