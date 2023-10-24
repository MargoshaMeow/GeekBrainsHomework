
// Задача 10: Напишите программу, которая принимает на вход трёхзначное
// число и на выходе показывает вторую цифру этого числа
Console.WriteLine("Enter a three digits number:");
int num = int.Parse(Console.ReadLine());
if (num <= 99 || num >= 1000) {
    Console.WriteLine("Incorrect number {0}.", num);
    return;
}
int second_digit = (num / 10) % 10;
Console.WriteLine("The second digit is {0}.", second_digit);
