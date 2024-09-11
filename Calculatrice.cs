using TPCalculatrice.Operations;

namespace TPCalculatrice;

public class Calculatrice
{

    public Operation Operation { get; }
    
    public int Resultat => Operation.Resultat;
    public Calculatrice(Operation operation)
    {
        Operation = operation;
    }

    public void Executer()
    {
        if(Operation is Addition addition)
        {
            addition.Executer();
        }
        else if(Operation is Soustraction soustraction)
        {
            soustraction.Executer();
        }
        else if(Operation is Multiplication multiplication)
        {
            multiplication.Executer();
        }
        else if(Operation is Division division)
        {
            division.Executer();
        }
        else if(Operation is Modulo modulo)
        {
            modulo.Executer();
        }
        else
        {
            Console.WriteLine("Opération non reconnue");
        }
    }

}
