using System;

namespace TPCalculatrice.Operations;

public class Addition : Operation
{
    public Addition(int operandeGauche, int operandeDroite) : base(operandeGauche, operandeDroite)
    {
    }

    public override void Executer()
    {
        Resultat = OperandeGauche + OperandeDroite;
    }
}
