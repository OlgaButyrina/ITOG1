// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равно 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


void PrintArray(string[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}
int NewArrayLength(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    return count;
}
string[] CreatedNewArray(string[] array, int N)
{
    string[] NewArray = new string[N];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            NewArray[j] = array[i];
            j++;
        }
    }
    return NewArray;
}
string[] array = { "57)", "the end", "@@", "1+2=3" };
PrintArray(array);
int n = NewArrayLength(array);
PrintArray(CreatedNewArray(array, n));