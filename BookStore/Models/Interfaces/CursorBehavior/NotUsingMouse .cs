using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualComputer.Models {
  class NotUsingMouse : ICursorBehavior{
    string  ICursorBehavior.Cursor() {
      Console.WriteLine("Not Using Mouse");
      return "Not Using Mouse";
    }
  }
}
