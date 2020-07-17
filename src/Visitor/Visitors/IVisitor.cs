using System.Linq.Expressions;
using Visitor.Elements;

namespace Visitor.Visitors
{
  public interface IVisitor
  {
    void Visit(Element element);
  }
}
