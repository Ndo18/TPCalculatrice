using System;

namespace TPCalculatrice.Operations;

public class Multiplication : Operation
{
    public Multiplication(int operandeGauche, int operandeDroite) : base(operandeGauche, operandeDroite)
    {
    }

      public void Executer()
    {
        Resultat = OperandeGauche * OperandeDroite;
    }
}
