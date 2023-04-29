// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int number; // определяем переменную и инициализируем ее
int remainderNumber;
int index = 1;

//Приветствие
Console.WriteLine ("Вывод чётных чисел в промежутке до введенного числа");
//Ввод числа
Console.Write ("Введите число - ");

number = int.Parse(Console.ReadLine());

// проверка числа
if (number <= 1)
{
   Console.WriteLine ("Введено некорректное число");   
}
else
{
    // вывод четных чисел
    while (index < number+1)
        {
        //Определение четности числа и вывод на экран
        remainderNumber = index %2;
        if ( remainderNumber == 0 )
            {
            Console.Write(" " + index);
            }
        index = index + 1; 
        }

}
