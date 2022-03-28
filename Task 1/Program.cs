/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
 и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
//Console.WriteLine ("Нажмите любую клавишу... | ESC - выход из консоли"); //бесконечный цикл есть, не знаю как его сделать лучше
//while(Console.ReadKey().Key != ConsoleKey.Escape)
//{


Console.Write("Введите число A:  ");                        // Ввод числа 
double valueA = Convert.ToDouble(Console.ReadLine());           //     A

Console.Write("Введите число B:  ");                        // Ввод числа
Double valueB = Convert.ToDouble(Console.ReadLine());           //     B

double temp = 0;                                               // Ввод переменных  
double valueEnd= 0;                                            // для работы с циклом
while (temp < valueB+1)                                     //-------------------------------------------------
                                                            //
{                                                           //  Цикл; Его можно сделать было и по другому.
    valueEnd = Math.Pow(valueA,temp);      //
    temp++;                                                 //
}                                                           //------------------------------------------------

    Console.WriteLine("Число {0} в степени {1} - {2} \n\n",valueA,valueB,valueEnd);      //Вывод
    
//}
