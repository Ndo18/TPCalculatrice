using System;

namespace TPCalculatrice.Operations;

public class Soustraction : Operation
{
    public Soustraction(int operandeGauche, int operandeDroite) : base(operandeGauche, operandeDroite)
    {
    }
      public override void Executer()
    {
        Resultat = OperandeGauche - OperandeDroite;
    }
}
