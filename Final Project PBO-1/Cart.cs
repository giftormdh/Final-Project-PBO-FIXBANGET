using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CartTemp
{
    public static class Cart
    {
        private static List<string> TempCart = new List<string>();

        public static void add(string name)
        {
            TempCart.Add(name);
        }
        public static void remove(int i)
        {
            TempCart.RemoveAt(i);
            for(int j=i+1; j < TempCart.Count; j++)
            {
                if (TempCart[j + 1] != null)
                {
                    TempCart.Insert(j, TempCart[j + 1]);
                    TempCart.RemoveAt(j + 1);
                }
            }
        }
        public static string show(int i)
        {
            return TempCart[i];
        }
        public static int len()
        {
            return TempCart.Count;
        }
        public static void clear()
        {
            TempCart.Clear();  
        }

    }
}
