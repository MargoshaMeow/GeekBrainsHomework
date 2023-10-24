
// Задача 10: Напишите программу, которая принимает на вход трёхзначное
// число и на выходе показывает вторую цифру этого числа
Console.WriteLine("Task 10:");
Console.WriteLine("Enter a three digits number:");
int num = int.Parse(Console.ReadLine());
if (num <= 99 || num >= 1000) {
    Console.WriteLine("Incorrect number {0}.", num);
} else {
    int second_digit = (num / 10) % 10;
    Console.WriteLine("The second digit is {0}.", second_digit);
}


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
Console.WriteLine("Task 13:");
Console.WriteLine("Enter a number:");
num = int.Parse(Console.ReadLine());
if (num < 100) {
    Console.WriteLine("The number {0} don't have the third digit.", num);
    return;
} else {
    int third_digit = (num / 100) % 10;
    Console.WriteLine("The third digit is {0}.", third_digit);
}
