// Заполнить массив
string[] CreateStringArray()
{
    Console.Write("Введите размер массива: ");
    int m = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[m];
    for (int i = 0; i < m; i += 1)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
        array[i] = Console.ReadLine();
    }
    return array;
}
// Вывод массива
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i += 1)
        Console.Write($"“{array[i]}”, ");
    Console.Write($"“{array[array.Length-1]}”]");
    Console.WriteLine();
}
// Создание нового массива по условию
string[] newArray(string[] array)
{
    int n = 0;
    int j = 0;
    for (int i = 0; i < array.Length; i += 1)
    {
        if (array[i].Length <= 3) n += 1;
    }
    string[] newArr = new string[n];
    for (int i = 0; i < array.Length; i += 1)
     {
        if (array[i].Length <= 3)
        {
            newArr[j] = array[i];
            j += 1;
        }
    }
    return newArr;
}

string[] array1 = CreateStringArray();
Console.WriteLine();
Console.WriteLine("Первоначальный массив:");
PrintArray(array1);
Console.WriteLine();               
string[] newArr = newArray(array1);
Console.WriteLine("Конечный массив:");
PrintArray(newArr);
