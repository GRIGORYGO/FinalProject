/*Задача: Написать программу, которая из имеющегося массива строк формирует
 массив из строк, длина которых меньше либо равна 3 символа. Первоначальный 
 массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
 При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
 Примеры:
 ["2", "hello",  "sun","33","world"] -> ["2", "33","sun"]
 ["1234", "1567", "-2", "computer science"] -> ["-2"]
 ["Russia", "Denmark", "Kazan"] -> [] */

 string [] CreateArray()
 {
    Console.WriteLine($"Введите массив строк с клавиатуры через пробел:");
    string  words = Console.ReadLine();
    if (words == null) { words = ""; };
    char[] separators = new char[] { ',', ' ' };
    string[] workArray = words.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    return workArray;
 }

string PrintArray(string [] workArray)
{
string elementsArr = "[";
for (int i = 0; i < workArray.Length; i++)
{
    if (i == workArray.Length - 1)
    {
        elementsArr += $"\"{workArray[i]}\"";
        break;
    }
    elementsArr += $"\"{workArray[i]}\", ";
}
elementsArr += "]";
return elementsArr;
}

int LenghtStringCheck(string[] workArray)
{
int count = 0;
foreach (string item in workArray)
{
    if (item.Length <= 3)
    {
        count++;
    }
}
return count;
}

string[] NewArray(string[] workArray)
{
    int newArrayLength = LenghtStringCheck(workArray);
    string[] newArray = new string[newArrayLength];
    int i = 0;
    foreach (string item in workArray)
    {
        if (item.Length <= 3)
        {
            newArray[i] = item;
            i++;
        }
    }
    return newArray;
}

string[] workArray = CreateArray();
string[] newArray = NewArray(workArray);
string firstArray = PrintArray(workArray);
string secondArray = PrintArray(newArray);
Console.WriteLine($"{firstArray}  :  {secondArray}");