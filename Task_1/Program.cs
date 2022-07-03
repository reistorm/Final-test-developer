// Написать программу, которая из имеющегося массива строк
// формирует массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный
// массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма

string[] GenArray()
{
    Console.Write("Введите число элементов массива: ");
    int n = int.Parse(Console.ReadLine());
    string[] array = new string[n];
    Console.Write($"Введите элементы массива из {n} символов: ");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }
    return array;
}

void PrintArray(string[] prarr)
{
    var str = string.Join(" ", prarr);
    Console.WriteLine(str);
}

string[] array = GenArray();
Console.WriteLine("Исходный массив: ");
PrintArray(array);

string[] SampleArray(string[] array)
{
    string[] newarray = new string[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4)
        {
            newarray[i] = array[i];
        }
        else if (array[i].Length > 3)
        {
            array[i] = string.Empty;
        }
    }
    return newarray;
}

string[] newarray = SampleArray(array);
Console.WriteLine("Элементы массива с числом элементов равным трем и меньше: ");
PrintArray(newarray);
