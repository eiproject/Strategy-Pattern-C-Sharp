using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualComputer.Models {
  class PersonalComputer : Computer {
    internal override void View() { }
    internal override void Specification() { }
    internal PersonalComputer() {
      cursorBehavior = new UsingMouse();
      powerBehavior = new NotUsingBattery();
      typingBehavior = new UsingExternalKeyboard();
    }
  }
}
