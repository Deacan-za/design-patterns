using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Models
{
  public interface ISavingsAccount
  {
    decimal Balance { get; set; }
  }
}
