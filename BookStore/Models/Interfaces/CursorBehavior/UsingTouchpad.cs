using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualComputer.Models {
  class UsingTouchpad : ICursorBehavior {
    string ICursorBehavior.Cursor() { 
      Console.WriteLine("Using Touchpad"); 
      return "Using Touchpad";
    }
  }
}
