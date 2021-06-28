using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualComputer.Models {
  class UsingTouchScreen : ICursorBehavior {
    string ICursorBehavior.Cursor() {
      Console.WriteLine("Using Touch Screen");
      return "Using Touch Screen";
    }
  }
}
