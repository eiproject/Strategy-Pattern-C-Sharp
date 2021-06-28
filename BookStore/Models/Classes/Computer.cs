using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualComputer.Models {
  abstract class Computer {
    // common data declared
    internal void Display() {
      Console.WriteLine("Liquid Crystal Display");
    }
    internal abstract void View();
    internal abstract void Specification();

    // interface declaration
    internal ICursorBehavior cursorBehavior;
    internal IPowerBehavior powerBehavior;
    internal ITypingBehavior typingBehavior;

    // checking the feature
    internal string checkCursor() {
      return cursorBehavior.Cursor();
    }
    internal string checkPower() {
      return powerBehavior.Battery();
    }
    internal string checkTyping() {
      return typingBehavior.Typing();
    }

    // setting the feature
    internal string setCursor(ICursorBehavior cb) {
      cursorBehavior = cb;
      return cursorBehavior.Cursor();
    }
    internal string setPower(IPowerBehavior pb) {
      powerBehavior = pb;
      return powerBehavior.Battery();
    }
    internal string setTyping(ITypingBehavior tb) {
      typingBehavior = tb;
      return typingBehavior.Typing();
    }
  }
}
