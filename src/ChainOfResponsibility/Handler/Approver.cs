using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Handler
{
  public abstract class Approver: IApprover
  {
    protected IApprover Successor;

    public void SetSuccessor(IApprover suc)
    {
      this.Successor = suc;
    }

    public abstract void ProcessRequest(Purchase purchase);

  }
}
