// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

//максимальное из двух чисел


int firstNumber; // определяем переменную и инициализируем ее
int secondNumber;

//Ввод чисел
Console.WriteLine( "Нахождение максимального числа из двух");
Console.Write("Введите первое число - ");
firstNumber = int.Parse(Console.ReadLine());
Console.Write("Введите второе число - ");
secondNumber = int.Parse(Console.ReadLine());
//Определение максимального числа и вывод на экран
if ( firstNumber > secondNumber )
    {
    Console.WriteLine(" Наибольшее число = " + firstNumber);
    Console.WriteLine(" Наименьшее число = " + secondNumber);
    }
else 
if ( secondNumber > firstNumber )
    {
    Console.WriteLine(" Наибольшее число = " + secondNumber);
    Console.WriteLine(" Наименьшее число = " + firstNumber);
    }
else
    {
    Console.WriteLine(" Числа равны");
    }
