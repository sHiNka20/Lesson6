int vvod(string mess)
{
    Console.Write(mess);
    int val = Convert.ToInt32(Console.ReadLine());
    return val;
}

int[] arrayInput(int lenght)
{
    int[] arr = new int[lenght];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = vvod($"Введите {i + 1}-й элемент : ");
    }
    return arr;
}

void print(int[] arr)
{
    for (int i = 0; i < arr.Length ; i++)
    {
        Console.WriteLine($"arr[{i}] = {arr[i]}");
    }
}

int count(int[] arr)
{
    int countp = 0;
    for (int i = 0; i < arr.Length ; i++)
    {
        if (arr[i] > 0)
        {
            countp++;
        }
    }
    return countp;
}

int lenght = vvod("Введите количество элементов > ");
int[] arr;
arr = arrayInput(lenght);
print(arr);
Console.WriteLine($"Количество элементов больше 0 - {count(arr)}");