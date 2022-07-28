// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

void PrintArray(string[] printArr)
{
    for (int i = 0; i < printArr.Length; i++)
    {
        System.Console.Write($"{printArr[i]} ");
    }
}

string[] firstArr = { "day", "Mon", "-2", "Wednesday", "Th", "Friday", "Saturday" };

int j = 0;
string[] secondArr = new string[firstArr.Length];
for (int i = 0; i < firstArr.Length; i++)
{
    string temp = firstArr[i];
    if (firstArr[i].Length < 4)
    {
        secondArr[j] = temp;
        j++;
    }
}

PrintArray(secondArr);
