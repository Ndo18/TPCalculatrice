using TPCalculatrice;
using TPCalculatrice.Operations;

Console.WriteLine("Bienvenue sur ma calculatrice");

while (true)
{
    Console.WriteLine("Saisissez l'opérateur ou 'q' pour quitter");
    string operateur = Console.ReadLine();

    if (operateur == "q")
    {
        break;
    }

Console.WriteLine("Saisissez le premier nombre");
var o1 = int.Parse(Console.ReadLine());

Console.WriteLine("Saisissez le deuxième nombre");
var o2 = int.Parse(Console.ReadLine());

IOperation operation;

if(operateur == "+"){
    operation = new Addition(o1, o2);
}
else if(operateur == "-"){
    operation = new Soustraction(o1, o2);
}
else if (operateur == "*"){
        operation = new Multiplication(o1, o2);
}
else if(operateur == "/"){
        operation = new Division(o1, o2);
}
else if(operateur == "%"){
        operation = new Modulo(o1, o2);
}
else{
    Console.WriteLine("Opérateur non reconnu");
    return;
}

Calculatrice calc = new(operation);
calc.Executer();

Console.WriteLine("Le résultat de votre opération est " + calc.Resultat);

}

Console.WriteLine("_________________");
Console.WriteLine("Historique :");

foreach (var ope in Historique.Operations)
{
    Console.WriteLine(ope.ToString());
}