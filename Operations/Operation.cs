// using System;

namespace TPCalculatrice.Operations;

public class Operation
{
    public int OperandeGauche { get; set; }
    public int OperandeDroite { get; set; }
    public int Resultat{ get; set; }


    public Operation(int operandeGauche, int operandeDroite){
        OperandeGauche = operandeGauche;
        OperandeDroite = operandeDroite;
    }
}
