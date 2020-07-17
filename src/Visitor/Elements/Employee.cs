using Visitor.Visitors;

namespace Visitor.Elements
{
  public class Employee: Element
  {
    public double Income { get; set; }
    public string Name { get; set; }
    public int VacationDays { get; set; }


    public override void Accept(IVisitor visitor)
    {
      visitor.Visit(this);
    }
  }
}
