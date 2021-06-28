using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualComputer.Models {
  class UsingExternalKeyboard : ITypingBehavior {
    string ITypingBehavior.Typing() {
      Console.WriteLine("Using External Keyboard");
      return "Using External Keyboard";
    }
  }
}
