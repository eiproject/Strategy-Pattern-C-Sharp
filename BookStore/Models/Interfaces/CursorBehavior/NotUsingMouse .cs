using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualComputer.Models {
  class NotUsingMouse : ICursorBehavior{
    void ICursorBehavior.Cursor() {
      Console.WriteLine("Not Using Mouse");
    }
  }
}
