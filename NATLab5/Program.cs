using NETLab5.Collection;
using NETLab5.Strategy;
using NETLab5.Sort;

namespace NETLab5
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var data = new DoubleCollection();
                var list = new List<double> { 0.56, 54.7, 13, -1567, 4.6, -3, 745, 11, 0, 1 };

                foreach (var item in list)
                {
                    data.Add(item);
                }

                Console.WriteLine("Маємо вибiрку:");

                foreach (var item in data)
                {
                    Console.Write(item + " ");
                }

                var isSortElse = false;
                while (!isSortElse)
                {
                    Console.WriteLine("\nОберiть тип алгоритму, за яким сортуватиметься масив: " +
                    "\n1. Bubble Sort натиснiть 1" +
                    "\n2. Insertion Sort натиснiть 2" +
                    "\n3. Merge Sort, натиснiть 3\n");

                    var variant = Convert.ToInt32(Console.ReadLine());

                    isSortElse = true;
                    switch (variant)
                    {
                        case 1:
                            DoSort(new AnalyseSort(), data, new BubbleSort());
                            break;
                        case 2:
                            DoSort(new AnalyseSort(), data, new InsertionSort());
                            break;
                        case 3:
                            DoSort(new AnalyseSort(), data, new MergeSort());
                            break;
                        default:
                            Console.WriteLine("Невiрне значення");
                            isSortElse = false;
                            break;
                    }

                    if (!isSortElse)
                    {
                        continue;
                    }

                    string? choice;
                    Console.WriteLine($"Якщо хочете просортувати масив ще раз, уведiть Y." +
                        "\nЯкщо хочете просортувати у протилежному порядку: R. " +
                        "\nЯкщо нi - будь-що iнше");
                    choice = Console.ReadLine();
                    if (choice == "Y")
                    {
                        isSortElse = false;
                    }
                    if (choice == "R")
                    {
                        data.Reverse();
                        isSortElse = false;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

         private static void DoSort(AnalyseSort analyse, DoubleCollection data, ISort sortType)
         {
             analyse.SetSort(sortType);
             analyse.SortAndShow(data);
             Console.WriteLine($"Вiдсортовано за {analyse.Elapsed} сек");
             Console.WriteLine($"Мiнiмальний елемент: {analyse.Min}. " +
                 $"Максимальний елемент: {analyse.Max}");
        }
    }
}
