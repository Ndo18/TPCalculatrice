// using System;

namespace TPCalculatrice.Operations;

public abstract class Operation : IOperation
{
    protected int OperandeGauche { get; set; }
    protected int OperandeDroite { get; set; }
    public int Resultat{ get; protected set; }


    protected Operation(int operandeGauche, int operandeDroite){
        OperandeGauche = operandeGauche;
        OperandeDroite = operandeDroite;
    }

    public abstract void Executer();
}
