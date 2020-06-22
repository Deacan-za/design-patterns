using System.Runtime.Remoting.Messaging;

namespace Singleton.Models
{
  public class Policy
  {
    private static readonly Policy _instance = new Policy();

    public static Policy Instance => _instance;

    public Policy()
    {
      
    }

    private int Id { get; set; } = 123;
    private string Insured { get; set; } = "Bob Dylan";

    public string GetInsuredName() => Insured;
  }
}
