Console.Clear();
string[] startArray = newArray();

string[] newArray()
{
    Console.Write("Введите значения через пробел: ");
    return Console.ReadLine().Split(" ");
}

int lengtsSymbol = 3;

string[] resultArray = new string[startArray.Length];
int i = 0;
for (int j = 0; j < startArray.Length; j++)
{
    if (startArray[j].Length <= lengtsSymbol)
    {
        resultArray[i] = startArray[j];
        i++;
    }
}

Console.WriteLine($"[{String.Join(", ", startArray)}] -> [{String.Join(", ", resultArray)}]");


