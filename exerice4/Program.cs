//Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7, min = 5
//a = 2 b = 10 -> max = 10, min = 2
//a = -9 b = -3 -> max = -3, min = -9

int max = 0;
int min = 0;

Console.WriteLine("Введите число а");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b");
int numberB = Convert.ToInt32(Console.ReadLine());


if(numberA > numberB) 
{
    max=numberA;
    min=numberB;
}
else {
    
    max=numberB;
    min=numberA;
}

Console.WriteLine("max = " + max + " и " + "min = " + min);


