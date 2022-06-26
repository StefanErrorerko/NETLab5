using NETLab5.Collection;
using NETLab5.Strategy;
using NETLab5.Sort;

namespace RefactoringGuru.DesignPatterns.Iterator.Conceptual
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DoubleCollection data = new DoubleCollection();
                var list = new List<double> { 0.56, 54.7, 13, -1567, 4.6, -3, 745, 11, 0, 1 };
                foreach(var item in list) data.Add(item);
                var analyse = new AnalyseSort();
                Console.WriteLine("Маємо вибiрку:");
                foreach (var item in data) Console.Write(item + " ");

                bool flag = false;
                while (!flag)
                {
                    Console.WriteLine("\nОберiть тип алгоритму, за яким сортуватиметься масив: " +
                    "\n1. Bubble Sort натиснiть 1" +
                    "\n2. Insertion Sort натиснiть 2" +
                    "\n3. Merge Sort, натиснiть 3\n");
                    int variant = Convert.ToInt32(Console.ReadLine());
                    flag = true;
                    switch (variant)
                    {
                        case 1:
                            DoSort(analyse, data, new BubbleSort());
                            
                            break;
                        case 2:
                            DoSort(analyse, data, new InsertionSort());
                            break;
                        case 3:
                            DoSort(analyse, data, new MergeSort());
                            break;
                        default:
                            Console.WriteLine("Невiрне значення");
                            flag = false;
                            break;
                    }
                    if (flag)
                    {
                        string? choice;
                        Console.WriteLine("Якщо хочете просортувати масив ще раз, уведiть Y. " +
                            "\nЯкщо хочете просортувати у протилежному порядку: R. " +
                            "\nЯкщо нi - будь-що iнше");
                        choice = Console.ReadLine();
                        if(choice == "Y") flag = false;
                        if (choice == "R")
                        {
                            data.Reverse();
                            flag = false;
                        }

                    }
                }
                

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

         private static void DoSort(AnalyseSort analyse, DoubleCollection data, ISort sorttype)
            {
                analyse.SetSort(sorttype);
                analyse.SortAndShow(data);
                Console.WriteLine($"Вiдсортовано за {analyse.Elapsed} сек");
                Console.WriteLine($"Мiнiмальний елемент: {analyse.Min}. " +
                    $"Максимальний елемент: {analyse.Max}");
        }
    }
}