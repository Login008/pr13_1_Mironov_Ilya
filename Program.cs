using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_1
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                ArrayList list = new ArrayList();
                list.Add(4.5);
                list.Add(18);
                list.AddRange(new string[] { "Студент", "Петров" });

                foreach (object e in list)
                {
                    Console.WriteLine(e);
                }
                Console.WriteLine();

                list.RemoveAt(0);
                list.Reverse();
                Console.WriteLine(list[1]);
                Console.WriteLine();

                for (int i = 0; i < list.Count; i++)
                {
                    Console.WriteLine(list[i]);
                }

                /////////////////////////////////////////////////

                ArrayList list1 = new ArrayList();
                list1.Add(7);
                list1.Add(28.2);
                list1.AddRange(new string[] { "Студент", "Стэтхем" });

                Console.Write("Введите с какой позиции требуется вставить новую коллекцию: ");
                int n = int.Parse(Console.ReadLine());
                    if (!(n < 0 || n > list.Count))
                    {
                        for (int i = 0; i < list1.Count; i++)
                        {
                            list.Insert(n, list1[i]);
                            n++;
                        }

                        foreach (object e in list)
                        {
                            Console.WriteLine(e);
                        }

                        n = n / 2;
                        Console.Write("Введите какое количество элементов требуется удалить: ");
                        int k = int.Parse(Console.ReadLine());
                            if (!(k > list.Count - n || k < 1))
                            {
                                for (int i = 0; i < k; i++)
                                {
                                    list.RemoveAt(n);
                                }

                                foreach (object e in list)
                                {
                                    Console.WriteLine(e);
                                }
                            }
                            else
                            {
                                Console.WriteLine("Количество чисел было либое больше, чем количество чисел, содержащихся чисел в коллекции с позиции n/2,\nлибо оно было меньше 1, введите заново");
                            }
                    }
                    else
                    {
                        Console.WriteLine("Введённое значение либо было меньше нуля, либо было больше размера коллекции\nВведите заново");
                    }
            } 
            catch
            {
                Console.WriteLine("Неверный формат данных, введите заново");
            }

            Console.ReadKey();
        }
    }
}
