using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualComputer.Models {
  class UsingTouchScreen : ICursorBehavior {
    void ICursorBehavior.Cursor() {
      Console.WriteLine("Using Touch Screen");
    }
  }
}
