using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualComputer.Models {
  abstract class Computer {
    internal void Display() { }
    internal abstract void View();
    internal abstract void Specification();

    internal ICursorBehavior cursorBehavior;
    internal IPowerBehavior powerBehavior;
    internal ITypingBehavior typingBehavior;

    internal void setCursor() {
      cursorBehavior.Cursor();
    }
    internal void setPower() {
      powerBehavior.Battery();
    }
    internal void setTyping() {
      typingBehavior.Typing();
    }
  }
}
