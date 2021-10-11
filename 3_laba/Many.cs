using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_laba
{
    public class Many
    {
        private int[] arr;

        public Many(string s)       //конструктор
        {
            string[] subs = s.Split(' ');
            for (int i = 0; i < subs.Length; i++)
            {
                arr[i] = int.Parse(subs[i]);
            }

        }

        public static string OpPlus(int[] a ,int[] b)   //объединение двух множеств
        {
            string s = "";
             int[] c = new int[a.Length+b.Length];
           // int[] c;

            for (int i = 0; i < a.Length; i++)
            {
                c[i] = a[i];
            }

            for (int i = 0; i < b.Length; i++)
            {
                c[i + a.Length] = b[i];
            }

            Array.Sort(c);


            int[] ch = c.Distinct().ToArray();

            for (int i = 0; i < ch.Length; i++)
            {
                s = s + ch[i]+" ";
            }
            
         //   s= c.Distinct().ToArray().ToString();

            return s;
        }


    }
}
