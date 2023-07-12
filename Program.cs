//Написать программу, которая из имеющегося массива строк формирует массив из строк,
//длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо
//задать на старте выполнения алгоритма. При решении не пользоваться коллекциями.

void SortedArray(string[] arrOne, string[] arrTwo)
{
    int count = 0;
    for (int i = 0; i < arrOne.Length; i++)
    {
        if(arrOne[i].Length <= 3)
        {
           arrTwo[count] = arrOne[i];
           count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

string[] arrayOne = new string[6] {"Hello", "GeekBrains","!!!!!", "Hi", "GB", "!!!"};
string[] arrayTwo = new string[arrayOne.Length];
SortedArray(arrayOne, arrayTwo);
PrintArray(arrayTwo);