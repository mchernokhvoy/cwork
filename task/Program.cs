void RealeseArray(string[] array)
{
    string newArray = string.Empty;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
            if (newArray == string.Empty)
                newArray = array[i];
            else
                newArray += " " + array[i];
    }
    string[] resultArray = newArray.Split(" ").ToArray();
    Console.WriteLine($"[{string.Join(", ", resultArray]");
}

Console.Clear();
string[] array = Console.ReadLine().Split(" ").ToArray();
Console.WriteLine("Исходный массив:");
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine("Итоговый массив:");
RealeseArray(array);