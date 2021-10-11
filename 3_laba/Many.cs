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

        public static string Union(int[] a, int[] b)
        {
            string s = "";
            int k = 0;
            bool check = false,check_b=false;
            int[] c = new int[a.Length + b.Length];

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    if (a[i] == b[j])
                    {
                        c[k] = a[i];
                        k++;
                    }
                    if (b[j] == 0)
                    {
                        check_b = true;
                    }
                }
                if (a[i] == 0)
                {
                    check = true;
                }
            }

            Array.Sort(c);
            int[] ch = c.Distinct().ToArray();

            if ((check == true) & (check_b ==true))
            { 
                for (int i = 0; i < ch.Length; i++)
                {
                s = s + ch[i] + " ";
                }
            }
            else
            {
                for (int i = 1; i < ch.Length; i++)
                {
                    s = s + ch[i] + " ";
                }
            }

            return s;
        }



    }
}
