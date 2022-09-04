int[] arr = {6, 7, 3, 6}; //исходный массив

int newLength = arr.Length / 2 + arr.Length % 2;

int[] resultArr = new int[newLength];

for (int i = 0; i < newLength; i++)
{
    resultArr[i] = arr[i] * arr[arr.Length - 1 - i];
}

if (arr.Length % 2 == 1)
{
   resultArr[resultArr.Length - 1] = arr[arr.Length / 2];
}

Console.WriteLine(string.Join(", ", resultArr)); //выводим результирующий массив
