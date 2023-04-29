// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

int evenNumber; // определяем переменную и инициализируем ее
int remainderNumber;

//Приветствие
Console.WriteLine ("Определение чётности числа");
//Ввод числа
Console.Write ("Введите число - ");

evenNumber = int.Parse(Console.ReadLine());
//Определение четности числа и вывод на экран
remainderNumber = evenNumber %2;
if ( remainderNumber == 0 )
{
    Console.WriteLine("Число чётное ");
}
else
{
    Console.WriteLine("Число нечётное ");
    }
