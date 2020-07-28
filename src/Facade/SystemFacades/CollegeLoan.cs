using System;
using Facade.Models;
using Facade.SubSystems;

namespace Facade.SystemFacades
{
  // The Facade Class.
  public class CollegeLoan
  {
    private Bank _bank = new Bank();
    private Loan _loan = new Loan();
    private Credit _credit = new Credit();

    public bool IsEligible(Student student, int amount)
    {
      Console.WriteLine($"{student.Name} applies for a {amount} loan");

      var eligible = true;

      // Verify credit worthiness of applicant
      if (!_bank.HasSufficientSavings(student, amount))
      {
        eligible = false;
      }
      else if(!_loan.HasNoBadLoans(student))
      {
        eligible = false;
      }
      else if(!_credit.HasGoodCredit(student))
      {
        eligible = false;
      }

      return eligible;
    }
  }
}
