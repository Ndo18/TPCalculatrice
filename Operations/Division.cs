using System;

namespace TPCalculatrice.Operations;

public class Division : Operation
{
    public Division(int operandeGauche, int operandeDroite) : base(operandeGauche, operandeDroite)
    {
    }

      public void Executer()
    {
        if(OperandeDroite != 0)
        {
            Resultat = OperandeGauche / OperandeDroite;
        }
    }
}
