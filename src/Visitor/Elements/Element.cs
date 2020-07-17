using Visitor.Visitors;

namespace Visitor.Elements
{
  public abstract class Element
  {
    public abstract void Accept(IVisitor visitor);
  }
}
