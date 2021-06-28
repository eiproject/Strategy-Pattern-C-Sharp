using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualComputer.Models {
  class UsingBattery : IPowerBehavior{
    void IPowerBehavior.Battery() {
      Console.WriteLine("Using Baterry");
    }
  }
}
