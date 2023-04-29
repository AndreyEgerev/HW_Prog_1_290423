// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

// функция нахождения максимального числа из двух
int FindMaximumNumber (int num1, int num2)
{
    int maxNum = 0;
    if (num1 >= num2){ //возвращаем num1 если оно больше или равно
        maxNum = num1;
    }
    else if (num1 < num2){ //возвращаем num2 если оно больше
        maxNum = num2;
    }
    return maxNum;
}

int firstNumber; // определяем переменную и инициализируем ее
int secondNumber;
int thirdNumber;
int maxNumber;

//Ввод чисел
Console.WriteLine( "Нахождение максимального числа из трех чисел");
Console.Write("Введите первое число - ");
firstNumber = int.Parse(Console.ReadLine());
Console.Write("Введите второе число - ");
secondNumber = int.Parse(Console.ReadLine());
Console.Write("Введите третье число - ");
thirdNumber = int.Parse(Console.ReadLine());

//Определение максимального числа через вызов функций и вывод на экран

maxNumber = FindMaximumNumber(firstNumber,secondNumber);
maxNumber = FindMaximumNumber(maxNumber, thirdNumber);
Console.WriteLine("Наибольшее число - " + maxNumber);

// if ( firstNumber > secondNumber )
//     {
//     Console.WriteLine(" Наибольшее число = " + firstNumber);
//     Console.WriteLine(" Наименьшее число = " + secondNumber);
//     }
// else 
// if ( secondNumber > firstNumber )
//     {
//     Console.WriteLine(" Наибольшее число = " + secondNumber);
//     Console.WriteLine(" Наименьшее число = " + firstNumber);
//     }
// else
//     {
//     Console.WriteLine(" Числа равны");
//     }