using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] primenum;

            using (FileStream fs = new FileStream(@"C:\Users\User\Desktop\pp2\task 2 in.txt", FileMode.Open, FileAccess.Read))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    string s = sr.ReadLine();   //прочитал с файла и дал это значение с файла на стринг
                    int[] num = f(s);           //функция или метод преобразовывает числы ввиде символ в норм числа и добав в массив 
                    primenum = fff(num);        //функ или метод который сортирует из массива прайм намберс
                }
            }


            using (FileStream fs1 = new FileStream(@"C:\Users\User\Desktop\pp2\task 2 out.txt", FileMode.Create, FileAccess.Write)) //создал файл, если сущ то перезаписывается
            {
                using (StreamWriter sw = new StreamWriter(fs1))   //это не для чтения а для записи
                {
                    foreach (var x in primenum)      //цикл который пишет в файл все числа из праймнам(все простые числа)
                    {
                        sw.Write(x + " ");
                    }
                }
            }
        }



        private static int[] f(string s)
        {
            string[] ss = s.Split(' ');
            int[] n = new int[ss.Length];
            for (int i = 0; i < ss.Length; i++)
            {
                n[i] = int.Parse(ss[i]); //преобразование
            }
            return n;

        }

        public static int[] fff(int[] num)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < num.Length; i++)
            {
                bool b = true;
                if (num[i] == 1)
                {
                    b = false;
                    continue;
                }
                for (int j = 2; j < num[i]; j++)
                {
                    if (num[i] % j == 0)
                    {
                        b = false;
                        break;
                    }
                    else b = true;
                }
                if (b) list.Add(num[i]);
            }
            return list.ToArray();   /// преобразование листа в массив
        }
    }
}