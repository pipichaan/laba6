//в матрице m x n заменить все нули максимальным элиментом
Console.WriteLine("Введите кол-во строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов");
int n = Convert.ToInt32(Console.ReadLine());
int[,] nums = new int[n, m]; //объявление двумерного массива

for (int i = 0; i < m; i++)//ввод строк
{
    for (int j = 0; j < n; j++)//ввод столбцов
    {
        Console.WriteLine("Введите данные");
        nums[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}
int max = nums[0, 0];//поиск наибольшего элемента массива
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (nums[i, j] > max)
        {
            max = nums[i, j];
        }
    }
}
for (int i = 0; i < m; i++)//поиск нулей
{
    for (int j = 0; j < n; j++)
    {
        if ((nums[i, j] == 0))
        {
            nums[i, j] = max;//замена нуля на максимальное значение
        }
    }
}
for (int i = 0; i < m; i++)//вывод элементов массива
{
    for (int j = 0; j < n; j++)
    {
        Console.WriteLine(nums[i, j]) ;
    }
}