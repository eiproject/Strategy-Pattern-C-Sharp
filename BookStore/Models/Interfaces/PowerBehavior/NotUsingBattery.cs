using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualComputer.Models {
  class NotUsingBattery : IPowerBehavior {
    void IPowerBehavior.Battery() {
      Console.WriteLine("Not Using Battery");
    }
  }
}
