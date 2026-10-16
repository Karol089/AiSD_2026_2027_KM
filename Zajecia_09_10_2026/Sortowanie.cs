using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia_09_10_2026
{
    internal class Sortowanie
    {
        public static void Babelkowe(int[] tab)
        {
            for(int i = 0; i < tab.Length - 1; i++)
            {
                for(int k = 0; k < tab.Length - 1; k++)
                {
                    if (tab[k] > tab[k + 1])
                    {
                        int temp = tab[k];
                        tab[k] = tab[k + 1];
                        tab[k + 1] = temp;
                    }
                }
            }
        }

        public static void PrzezWstawianie(int[] liczby)
        {
            for(int sup = 0; sup < liczby.Length; sup++)
            {
                int temp = liczby[sup];
                for(int sub = sup; sub > 0; sub--)
                {
                    if (temp > liczby[sub - 1])
                    {
                        liczby[sub] = temp;
                        break;
                    } else
                    {
                        liczby[sub] = liczby[sub - 1];
                    }                   
                }               
            }
        }

        public static int[] PrzezScalanie(int[] liczby)
        {
            if (liczby.Length == 1)
            {
                return liczby;
            }
            int[] tabLeft = PrzezScalanie(liczby[..(liczby.Length / 2)]);
            int[] tabRight = PrzezScalanie(liczby[(liczby.Length / 2)..]);
            for(int i = 0, l = 0, r = 0; i < liczby.Length; i++)
            {
                if(l >= tabLeft.Length)
                {
                    liczby[i] = tabRight[r];
                    r++;
                } else if(r >= tabRight.Length)
                {
                    liczby[i] = tabLeft[l];
                    l++;
                } else if (tabLeft[l] > tabRight[r])
                {
                    liczby[i] = tabLeft[l];
                    l++;
                } else
                {
                    liczby[i] = tabLeft[r];
                    r++;
                }
            
            }
            return liczby;
            

        }

        public static int[] Konwertuj(string liczby)
        {
            String[] liczby_s = liczby.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int[] liczby_i = new int[liczby_s.Length];
            for(int i = 0; i < liczby_s.Length; i++)
            {
                liczby_i[i] = int.Parse(liczby_s[i]);
            }
            return liczby_i;
        }
    }

}
