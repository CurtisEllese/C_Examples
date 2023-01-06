int[] array = { 11, 2, 23, 188, 4, 95, 46, 188 };

int n = array.Length;
int find = 188;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    };
    index++;
};
