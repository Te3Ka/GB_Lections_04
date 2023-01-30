/***********************/
/*****Te3Ka_PaynE*******/
/*Mnement4813@yandex.ru*/
/***********************/

/*
Факториал через рекурсию
*/

//Метод с указанием автора
void Author()
{
    Console.WriteLine();
    Console.WriteLine("Программа создана Te3Ka_PaynE.");
    Console.WriteLine("E-mail: Mnement4813@yandex.ru");
    Console.WriteLine();
}

double Factorial(double num)
{
    if (num == 1)
        return 1;
    else if (num == 0)
        return 1;
    else
        return num * Factorial(num - 1);
}

Console.Write("Введите число, для которого нужно посчитать факториал = ");
int.TryParse(Console.ReadLine(), out int number);
Console.WriteLine($"{number}! = {Factorial(number)}");