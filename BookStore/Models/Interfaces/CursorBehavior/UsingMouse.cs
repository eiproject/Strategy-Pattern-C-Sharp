using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualComputer.Models {
  class UsingMouse : ICursorBehavior{
    void ICursorBehavior.Cursor() {
      Console.WriteLine("Using Mouse");
    }
  }
}
