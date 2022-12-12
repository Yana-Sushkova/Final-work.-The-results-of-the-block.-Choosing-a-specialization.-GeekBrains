/* ЗАДАЧА:
Написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых либо меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма.
При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
*/

string[] array1 = new string[5] {"123", "23", "hello", "world", "res"};
string[] array2 = new string[array1.Length];

int len = GetArrayWithIf(array1, array2);
PrintArray(array2, len);


int GetArrayWithIf(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
    return count;
}

void PrintArray(string[] array, int len)
{
    Console.Write("[");

    for (int i = 0; i < len; i++)
    {
        Console.Write($"\"{array[i]}\"");
        if (i != len - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}