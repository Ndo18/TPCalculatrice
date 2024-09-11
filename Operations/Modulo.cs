using System;

namespace TPCalculatrice.Operations;

public class Modulo : Operation
{
    public Modulo(int operandeGauche, int operandeDroite) : base(operandeGauche, operandeDroite)
    {
    }
      public override void Executer()
    {
        Resultat = OperandeGauche % OperandeDroite;
    }
}
