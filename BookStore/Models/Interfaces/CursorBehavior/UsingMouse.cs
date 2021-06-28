using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualComputer.Models {
  class UsingMouse : ICursorBehavior{
    string ICursorBehavior.Cursor() {
      Console.WriteLine("Using Mouse");
      return "Using Mouse";
    }
  }
}
