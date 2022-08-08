Console.Write("Введите число А: ");
string a = Console.ReadLine();
Console.Write("Введите натуральное число B (от 1): ");
string b = Console.ReadLine();
double degreeResult;
double RaiseToADegree(double number, int degreeOfNumber)
{
    double degree = 1;
    for (int i = 0; i < degreeOfNumber; i++)
    {
        degree *= number;
    }
    return degree;
}
void ExceptionHandling(string enterA, string enterB)
{
    bool yesDouble = double.TryParse(enterA, out double resultNumber);
    bool yesInt = int.TryParse(enterB, out int result);
    if (yesInt && yesDouble && result > 0)
    {
        degreeResult = RaiseToADegree(resultNumber, result);
        Console.WriteLine("{0} в степени {1} = {2}",
                          resultNumber, result, degreeResult);
    }
    else 
    {
        Console.WriteLine("{0}, {1} -> Некорректный ввод!", a, b);
    }
}
ExceptionHandling(a, b);