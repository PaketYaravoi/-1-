// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное на само себя)

// Например:
// 4 -> 16 
// -3 -> 9
// -7 -> 49


Console.WriteLine("Введите любое число и я найду его корень!");
string input = Console.ReadLine()!;

int number = int.Parse(input);
int square = number * number;

Console.WriteLine($"квадрат числа {number} равен {square}.");