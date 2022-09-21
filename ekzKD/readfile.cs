using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.Collections;
using Microsoft.VisualBasic.FileIO;
using System.Security.Cryptography;

namespace ekzKD
{
    public class readfile
    {
        /// <summary>
        /// Метод читающий .csv файл
        /// </summary>
        /// <param name="filecsvNR"></param>
        public static void readcsv(string filecsvNR)
        {
            using (TextFieldParser tfp = new TextFieldParser(filecsvNR))
            {
                tfp.TextFieldType = FieldType.Delimited;
                tfp.SetDelimiters(";");
                string[] file_name = null;
                while (!tfp.EndOfData)
                {
                    file_name = tfp.ReadFields();
                }
            }
        }
        /// <summary>
        /// Метод читающий .txt файл
        /// </summary>
        /// <param name="filetxtNR"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <param name="day"></param>
        public static void readtxt(string filetxtNR, int i, int j, int day)
        {
            
            string[] file_name = File.ReadAllLines(@filetxtNR);
            for (int t = 0; t < file_name.Length; t++)
            {
                if (t == 0)
                {
                    i = Convert.ToInt32(file_name[0]);
                }
                if (t == 1)
                {
                    j = Convert.ToInt32(file_name[t]);
                }
                if (t == 2)
                {
                    day = Convert.ToInt32(file_name[t]);
                }
            }
            Console.WriteLine(i);
            Console.ReadLine();


            int[] I = new int[i.ToString().Length];
            for (int t = 0; t < I.Length; t++)
            {
                I[t] = i % 10;
                i /= 10;

            }
            Array.Reverse(I);
            //Console.WriteLine(I[0]);

            int maxJ = 0;
            int[] J = new int[j.ToString().Length];
            for (int t = 0; t < J.Length; t++)
            {
                J[t] = j % 10;
                j /= 10;
                if (maxJ < J[t])
                {
                    maxJ = J[t];
                }
            }
            Array.Reverse(J);
            //Console.WriteLine(maxJ);

            int[] Day = new int[day.ToString().Length];
            for (int t = 0; t < Day.Length; t++)
            {
                Day[t] = day % 10;
                day /= 10;
            }
            Array.Reverse(Day);
        }
    }
}
