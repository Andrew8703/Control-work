﻿/* Задача:   
Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.  
Примеры:  
["hello", "2", "world", ":-)"] -> ["2", ":-)"]  
["1234", "1567", "-2", "computer science"] -> ["-2"]  
["Russia", "Denmark", "Kazan"] -> []    */

Console.Clear();
Console.Write("Введите элементы массива через пробел: ");
string text = Console.ReadLine(); //Вводим любое кол-во (слов/наборов симолов) через пробел которые затем сформируют
//первоначальный массив
string[] firstArray = text.Split(" "); //Создаем 1 массив с размером равным кол-ву ранее введенных элемнтов, через пробел
string[] secondArray = new string[0]; //Создаем 2 массив с размером равным 0
int j = 0; //Создаем переменную которая будет соответствовать элементам второго массива
for (int i = 0; i < firstArray.Length; i++) // Пока i-й элемент 1 массива меньше его длинны (проверяем условие if) 
{
    if (firstArray[i].Length <= 3)//Если i-й элемент массива удовлетворяет условию (содержит 3 или менее символов)
    {
        Array.Resize(ref secondArray, secondArray.Length + 1);//Увеличиваем 2 пустой массив на один элемент
        secondArray[j] = firstArray[i];//Присваеваем ему значение i-ого элемента из 1 массива
        j++;
    }
}
string str = string.Join(" ", secondArray);//Соединяем в строку элементы 2 массива для вывода
Console.WriteLine();
Console.WriteLine("Введенный массив: " + text);
Console.WriteLine();
if (secondArray.Length != 0) Console.Write("Измененный массив : " + str);
else Console.WriteLine("В изначальном массиве нет подходящих элементов!");

//Hello! My name is Jack! Iam 20 yars old!
