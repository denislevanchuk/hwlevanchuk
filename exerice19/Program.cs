// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Введите пятизначное число: ");
        int num = int.Parse(Console.ReadLine());
        
        
        if (num < 10000 || num > 99999) {
            Console.WriteLine("Ошибка! Введено не пятизначное число.");
            return;
        }
        
        
        int a = num / 10000;
        int b = (num / 1000) % 10;
        int c = (num / 100) % 10;
        int d = (num / 10) % 10;
        int e = num % 10;
        
       
        if (a == e && b == d) {
            Console.WriteLine($"{num} является палиндромом!");
        } else {
            Console.WriteLine($"{num} не является палиндромом.");
        }
    }
}
