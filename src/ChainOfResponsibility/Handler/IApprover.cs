using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Handler
{
  public interface IApprover
  {
    void SetSuccessor(IApprover suc);
    void ProcessRequest(Purchase purchase);
  }
}
