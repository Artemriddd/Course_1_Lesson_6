using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les_6_Ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Process[] notepad = Process.GetProcesses();
            while (true)
            {
                Console.WriteLine("- Выход наберите 0");
                Console.WriteLine("- Список процессов наберите -1");
                Console.Write("Введите номер процесса для его завершения: ");
                try
                {
                    int a = Int32.Parse(Console.ReadLine());
                    if (a == 0)
                    {
                        break;
                    }
                    else if (a > notepad.Length - 1 || a < -1)
                    {
                        Console.WriteLine("Введите корректное число!");
                    }
                    else if (a == -1)
                    {
                        for (int i = 0; i < notepad.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}. {notepad[i].ProcessName}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Процесс {notepad[a - 1].ProcessName} завершён!");
                        notepad[a - 1].Kill();
                    }
                }
                catch
                {
                    Console.WriteLine("Введите корректное число!");
                }
            }
        }
    }
}
