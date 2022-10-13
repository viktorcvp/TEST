Console.WriteLine("введите первое число a");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите второе число b");
int b = Convert.ToInt32(Console.ReadLine());


if (a > b)
{
    Console.WriteLine(a + "больше" + b);
}

else Console.WriteLine("число" + b + "больше" + a);
//Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна трём символам. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.
string[] into_mas = { "hello", "pax", "777", "god", "vik", "3737", "milot" };

string[] SearchForThrdCharString(string[] in_mas)
{
    string[] beyond_mas = new string[1];
    int j = 0;
    for (int i = 0; i < into_mas.Length; i++)
    {
        if (in_mas[i].Length <= 3)
        {
            Array.Resize(ref beyond_mas, 1 + j);
            beyond_mas[j] = into_mas[i];
            j++;
        }
    }
    return beyond_mas;
}
System.Console.WriteLine(String.Join("|", SearchForThrdCharString(into_mas)));