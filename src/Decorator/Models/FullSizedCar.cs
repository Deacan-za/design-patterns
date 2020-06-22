using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Models
{
  class FullSizedCar: Car
  {
    public FullSizedCar()
    {
      Description = "Full sized car";
    }

    public override string GetDescription() => Description;

    public override double GetPrice() => 30000.00;

  }
}
