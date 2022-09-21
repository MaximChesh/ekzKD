using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ekzKD
{
    //критический путь это наибольшая продолжительность
    //значения i, j, dayij, maxday (ответ)
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                int i = 0;
                int j = 0;
                int day = 0;
                try
                {
                    Console.WriteLine("Введите путь .csv файла для чтения данных: \n");
                    string filecsvNR = Console.ReadLine();

                    readfile.readcsv(filecsvNR);
                }
                catch (Exception) { Console.WriteLine("Ошибка введенном пути файла"); }

                try
                {
                    Console.WriteLine("Введите путь .txt файла для чтения данных: \n");//D:\ProgrammVS\ekz_Pm02\ekz_Pm02-master\ekzKD\bin\Debug\krit_puti.txt
                    string filetxtNR = Console.ReadLine();

                    readfile.readtxt(filetxtNR, i, j, day);
                }
                catch (Exception) { Console.WriteLine("Ошибка введенном пути файла"); }

                //i = txtfile.readtxt(fileName, i, j, day);

                //j = txtfile.readtxt(fileName, i, j, day);
                //day = txtfile.readtxt(fileName, i, j, day);

                //for (int t = 0; t < I.Length; t++)
                //{
                //    Console.WriteLine(I[t]);
                //}

                string result = @"456";
                try
                {
                    Console.WriteLine("Введите путь файла для сохранения данных: \n");//D:\ProgrammVS\ekz_Pm02\ekz_Pm02-master\ekzKD\bin\Debug\result.txt
                    string fileNamewrite = Console.ReadLine();

                    writefile.writetxt(@fileNamewrite, result);
                }
                catch (Exception) { Console.WriteLine("Ошибка введенном пути файла"); }

                Console.ReadKey();
            }
            catch (Exception) { Console.WriteLine("Ошибка ввода данных");}
        }
        
    }
}
