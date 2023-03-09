// Удаление элементов массива длина(размер) которых больше 3

Console.WriteLine("Hello!");
Console.WriteLine();
Console.Write("Введите размер массива: ");

int sizeArray = Convert.ToInt32(Console.ReadLine());
string [] str = new string [sizeArray];

Console.WriteLine("Введите элементы массива");
FillArray(str);
string [] str1 = SortedArray(str);
Console.Write("Массив из элементов размером меньше или равным 3: ");
Console.WriteLine(string.Join(" ", str1));

void FillArray(string [] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Console.ReadLine();
    }
    Console.WriteLine("Достаточно");
    Console.WriteLine();
}

string [] SortedArray(string [] array)
{
    string [] arr = new string [array.Length];
    int count = 0; // добавил счетчик, что бы небыло пустых промежутков между элементами
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            arr[count] = array[i];
            count++;
        }
    }
    return arr;
}



