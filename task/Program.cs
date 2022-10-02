// написать программу, которая из имеющегося массива строк формирует массив из строк,
// длинакоторых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться алгоритмами, лучше обойтись исключительно массивами.
 Console.Clear();

 string[] array1 = new string[3] {"2", "hello", "world"};
 string[] array2 = new string[array1.Length];
void FinalArray(string[] array1, string[]array2){
    int count =0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <=3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}
void PrintArray (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
FinalArray(array1, array2);
Console.WriteLine("Вывод массива строк, длина которых меньше либо равна 3 символа: ");
PrintArray(array2);