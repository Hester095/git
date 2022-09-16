void FillArray(string[] tempArray, string[] oldArray)
{
    int i = 0;
    int j = 0;
    {
        for (i = 0; i < oldArray.Length; i++)
        {
            string s = oldArray[i];
            if (s.Length <= 3)
            {
                tempArray[j] = oldArray[i];
                Console.Write($"{tempArray[j]} ");
                j++;
            }
        }
    }
}

Console.Write("Введите размер массива: ");
string inputNumberOfArray = Console.ReadLine();
int numberOfArray = int.Parse(inputNumberOfArray);
//Инициализация и заполнение массива
string[] arrayOfString = new string[numberOfArray];
int i = 0;
int count = 0;
for (i = 0; i < numberOfArray; i++)
{
    Console.WriteLine($"Введите {i + 1}-е число массива: ");
    arrayOfString[i] = Console.ReadLine();
    string s = arrayOfString[i];
    if (s.Length <= 3)
    {
        count++;
    }
}
string[] newArray = new string[count];
Console.WriteLine(
    "Массив, в котором содержатся числа, длина которых меньше или равна 3-м символам: "
);
FillArray(newArray, arrayOfString);