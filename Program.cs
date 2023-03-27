//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

Random rnd = new Random();
double[] nums = new double[4]; ;
double min = 20;
double max = 0;

for (int i = 0; i < nums.Length; i++)
{
    nums[i] = rnd.NextDouble() * 20;
    Console.Write(nums[i] + " ");
    if (max < nums[i]) max = nums[i];
    if (min > nums[i]) min = nums[i];
}

Console.WriteLine($"-> {max - min}");
