/* Напишите программу, которая на вход принимает число и выдаёт, является ли число 
чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет
*/

Console.WriteLine("Введите число, которое вы хотите проверить на четное оно или нет: ");
string numberA = Console.ReadLine();
int number = int.Parse(numberA);

if( number == number / 2)
{
    int result = (number/2); 
    Console.WriteLine($"Данное число является четным {result}");
}
else
{
    Console.WriteLine($"Данное число не является четным ");
}

