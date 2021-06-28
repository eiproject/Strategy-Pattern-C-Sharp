using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualComputer.Models {
  class UsingExternalKeyboard : ITypingBehavior {
    void ITypingBehavior.Typing() {
      Console.WriteLine("Using External Keyboard");
    }
  }
}
