﻿namespace Interpreter.Expressions
{
  public class ThousandExpression: Expression
  {
    public override string One() => "M";

    public override string Four() => " ";
 

    public override string Five() => " ";


    public override string Nine() => " ";

    public override int Multiplier() => 1000;

  }
}
