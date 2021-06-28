using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualComputer.Models {
  abstract class Computer {
    // common data declared
    internal void Display() { }
    internal abstract void View();
    internal abstract void Specification();

    // interface declaration
    internal ICursorBehavior cursorBehavior;
    internal IPowerBehavior powerBehavior;
    internal ITypingBehavior typingBehavior;

    // checking the feature
    internal void checkCursor() {
      cursorBehavior.Cursor();
    }
    internal void checkPower() {
      powerBehavior.Battery();
    }
    internal void checkTyping() {
      typingBehavior.Typing();
    }

    // setting the feature
    internal void setCursor(ICursorBehavior cb) {
      cursorBehavior = cb;
    }
    internal void setPower(IPowerBehavior pb) {
      powerBehavior = pb;
    }
    internal void setTyping(ITypingBehavior tb) {
      typingBehavior = tb;
    }
  }
}
