using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualComputer.Models {
  class UsingTouchKeyboard : ITypingBehavior {
    void ITypingBehavior.Typing() {
      Console.WriteLine("Using Touch Keyboard");
    }
  }
}
