using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualComputer.Models {
  class UsingBattery : IPowerBehavior{
    string IPowerBehavior.Battery() {
      Console.WriteLine("Using Baterry");
      return "Using Battery";
    }
  }
}
