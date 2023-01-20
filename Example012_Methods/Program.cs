// Вид 1.

// void Method1()
// {
//     Console.WriteLine("Автор Я");
// }

// Method1();

// Вид 2.

// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }

// Method2(msg: "Автор Я");

// Вид 3.

// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();

// Console.WriteLine(year);

// Вид 4.

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty;

//     while (i < count)
//     {
//         result = result + text;
//         i++;
//     }
//     return result;
// }

// string res = Method4(10, "z");
// Console.WriteLine(res);

// string Method4(int count, string text)
// {
//     string result = String.Empty;

//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }

// string res = Method4(10, "z");
// Console.WriteLine(res);

// for (int i = 2; i <= 9; i++)
// {
//     for (int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i * j}");
//     }
//     Console.WriteLine();
// }



//======Работа с текстом
// Дан текст. В тексте нкжно все пробелы заменить черточками, меленькие буквы "к" заменить большими "К", а большие "С" заменить маленькими.

// string text = "— Я думаю, — сказал князь, улыбаясь, — что, ежели бы вас послали вместо нашего милого Винценгероде, вы бы взяли приступом согласие прусского короля. Вы так красноречивы. Вы дадите мне чаю?";

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;

//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }

// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();

// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();

// newText = Replace(newText, 'С', 'с');
// Console.WriteLine(newText);
// Console.WriteLine();




// Сортировка массива методом выбора
// по возрастанию
int[] arr = { 1, 5, 3, 7, 6, 4, 9, 8, 10 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSortAsc(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }

        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSortDesc(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }

        int temp = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temp;
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

PrintArray(arr);
SelectionSortDesc(arr);
