/***********************/
/*****Te3Ka_PaynE*******/
/*Mnement4813@yandex.ru*/
/***********************/

/*
Числа Фиббоначи через рекурсию
*/

//Метод с указанием автора
void Author()
{
    Console.WriteLine();
    Console.WriteLine("Программа создана Te3Ka_PaynE.");
    Console.WriteLine("E-mail: Mnement4813@yandex.ru");
    Console.WriteLine();
}

double Fibbonacci (double num)
{
    if ((num == 1) || (num == 2))
        return 1;
    else
        return Fibbonacci(num - 1) + Fibbonacci(num - 2);
}
Console.Write("Введите число для подсчёт суммы чисел Фиббоначи = ");
int.TryParse(Console.ReadLine(), out int number);
Console.WriteLine($"{number} = {Fibbonacci(number)}");