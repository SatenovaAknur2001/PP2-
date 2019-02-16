using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream fs = new FileStream(@"C:\Users\User\Desktop\pp2\task 1.txt", FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sw = new StreamReader(fs))
                {
                    string text = sw.ReadToEnd();
                    Console.WriteLine(text);

                    bool pol = true;
                    for (int i = 0; i < text.Length; i++)     // проверяю первую и последнюю, вторую и предпосл, и тд
                    {
                        if (text[i] == text[text.Length - 1 - i])
                        {
                            pol = true;
                        }
                        else
                        {
                            pol = false;
                            break;
                        }
                    }
                    if (pol) Console.WriteLine("Yes");      //вывод ответа
                    else Console.WriteLine("No");
                }
            }
        }
    }
}
