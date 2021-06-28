using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualComputer.Models {
  class UsingTouchKeyboard : ITypingBehavior {
    string ITypingBehavior.Typing() {
      Console.WriteLine("Using Touch Keyboard");
      return "Using Touch Keyboard";
    }
  }
}
