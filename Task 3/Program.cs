/* Напишите программу, которая задаёт массив из N(-100 100) рандомных элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

Console.Write("Введите количетсво элементов массива: ");
int valueN = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Массив из {0} элементов: \n",valueN);
for (int i = 0; i < valueN; i++)
{
    int[] array = new int[valueN];
    Random rand = new Random();
    array[i]= rand.Next(-100,100);
    Console.Write(array[i]);
    Console.Write(" | ");
}

