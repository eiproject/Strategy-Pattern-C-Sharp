using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualComputer.Models {
  class PersonalComputer : Computer {
    internal override void View() {
      Console.WriteLine("Personal Computer unique view");
    }
    internal override void Specification() {
      Console.WriteLine("Personal Computer unique specification");
    }
    internal PersonalComputer() {
      View();
      Specification();
      cursorBehavior = new NotUsingMouse();
      powerBehavior = new NotUsingBattery();
      typingBehavior = new UsingExternalKeyboard();
    }
  }
}
