using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualComputer.Models {
  class NotUsingBattery : IPowerBehavior {
    string IPowerBehavior.Battery() {
      Console.WriteLine("Not Using Battery");
      return "Not Using Battery";
    }
  }
}
