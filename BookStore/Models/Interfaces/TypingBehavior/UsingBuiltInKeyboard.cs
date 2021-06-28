using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualComputer.Models {
  class UsingBuiltInKeyboard : ITypingBehavior{
    string ITypingBehavior.Typing() {
      Console.WriteLine("Using Built In Keyboard");
      return "Using Built In Keyboard";
    }
  }
}
