
// ************ 3 ВАРИАНТ *************

const int n = 10;

// *********** 1 *************
Random r = new Random();
int[] arr2 = new int[n];
int k1 = 0, k2 = 0, k2prev = 0, FirstIndex = -1, SecondIndex = -1, PrevSecondIndex = -1, FirstNumber, SecondNumber;
for (int i = 0; i < n; i++) arr2[i] = r.Next(-100, 100);
for (int i = 0; i < n; i++)
{
    if (arr2[i] >= 0)
    {
        k1++;
        if (k1 == 2) FirstIndex = i;
    }
    if (arr2[i] < 0)
    {
        PrevSecondIndex = SecondIndex;
        SecondIndex = i;
    }
}
if (FirstIndex != -1 && PrevSecondIndex != -1)
{
    FirstNumber = arr2[FirstIndex]; SecondNumber = arr2[PrevSecondIndex];
    arr2[FirstIndex] = SecondNumber; arr2[PrevSecondIndex] = FirstNumber;
}
for (int i = 0; i < n; i++) Console.Write($"{arr2[i]} ");
Console.WriteLine("\n");
// ************ 2 *************

int count = 0; double sum = 0;
int[] arr = new int[n] {1,-22,-3,4,-5,-7,6,8,-9,-8 };
for (int i = 0; i < n; i++)
{
    if (arr[i] < 0)
    {
        sum += (double)arr[i];
        count++;
    }
    Console.Write($"{arr[i]} ");
}
Console.WriteLine($"\nСреднее арифмитическое всех отрицательных чисел массива: {sum}/{count}={sum/count}\n");

// ************* 3 **************
bool flag = true;
Console.WriteLine($"Введите кол-во строк(4): ");
int p = int.Parse( Console.ReadLine() );
Console.WriteLine($"Введите кол-во столбцов(4):");
int m = int.Parse(Console.ReadLine());
if (m != p) Console.WriteLine("Кол-во столбцов должно совпадать с кол-вом строк");
else
{
    // Через рандом симметричеую матрицу найти почти невозможно, через ввод слишком долго, поэтому, как вы сказали, я сделал фиксированную матрицу 4 на 4
    int[,] matrix = new int[4, 4] { { 1, 0, 0, 1 }, { 0, 1, 1, 0 }, { 1, 0, 0, 1 }, {0,1,1,0 } };
    for (int i = 0; i < m; i++)
    { 
        for (int j = 0; j < m; j++)
        {
            if (matrix[i,j] != matrix[i,(m-1)-j]) flag = false;
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
    if (flag) Console.WriteLine("Матрица симметрична");
    else Console.WriteLine("Матрица не симметрична");
}