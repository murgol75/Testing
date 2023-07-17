

using Testing.BLL;

Console.WriteLine("DEMO DE LA CALCULATRICE");
#region Input User

Console.Write("veuillez entrer l'operation");
string operation = Console.ReadLine() ?? string.Empty;

Console.Write("veuillez entrer le nombre 1");
double val1 = double.Parse(Console.ReadLine()!);

Console.Write("veuillez entrer le nombre 2");
double val2 = double.Parse(Console.ReadLine()!);
#endregion

#region Logic
Calculator calculator = new Calculator();

string resultMessage;
switch (operation)
{
    case "+":
        double result = calculator.Add(val1, val2);
        resultMessage = $"l'addition de {val1} et {val2} donne {result}";
        break;
    default:
        resultMessage = "l'operation n'est pas supportée";
        break;
}


#endregion


#region Displey result
Console.WriteLine("résultat de l'opération");
Console.WriteLine(resultMessage);


#endregion