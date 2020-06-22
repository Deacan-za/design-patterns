using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Models
{
  public abstract class Car
  {
    public string Description { get; set; }
    public abstract string GetDescription();
    public abstract double GetPrice();
  }
}
