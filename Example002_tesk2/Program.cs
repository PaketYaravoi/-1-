// Задача 1 - Написать программу которая на вход принимает два числа и проверяет, является ли первое число квадратом второго

/* 
a = 25 , b =5 -> Да
 a = 2 , b = 10  ->  нет 
 a = 9 , b = -3 -> да
 a = -3 , b = 9-> нет
 */
 
 /*
 1) нужна строка ввода данных куда указываем числа number1 and number2
 2) нужна строка преобразования readline в число
 3) нужна проверка "если"
 4) и нужно вывод "да или нет"


 */

 Console.WriteLine("Ведите два числа поочередно, через клавишу Enter ");
 Console.WriteLine("а я скажу является ли первое число, квадратом второго!");
 Console.Write("Ведите первое число:");
 
 string input = Console.ReadLine()!;
 Console.Write("Супер! Теперь второе число:");
 string input2 = Console.ReadLine()!;
 
 int number1 = int.Parse(input);
 int number2 = int.Parse(input2);
 
 if(number2 * number2 == number1)
 {
    Console.WriteLine($"число {number1} - это квадрат числа {number2}");
 }
else
{
    Console.Write($"число {number1} - не является квадратом числа {number2}");
}
