using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualComputer.Models {
  class UsingBuiltInKeyboard : ITypingBehavior{
    void ITypingBehavior.Typing() {
      Console.WriteLine("Using Built In Keyboard");
    }
  }
}
