﻿//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArray(numbers);
PrintArray(numbers);
int sum = 0;
for (int i = 0; i < numbers.Length; i+=2)
sum = sum + numbers[i];
Console.WriteLine($"->  {sum}");
void FillArray(int[] numbers){for(int i = 0; i < numbers.Length; i++){numbers[i] = new Random().Next(1,9);}}
void PrintArray(int[] numbers){for(int i = 0; i < numbers.Length; i++){Console.Write(numbers[i] + " ");}Console.WriteLine();}