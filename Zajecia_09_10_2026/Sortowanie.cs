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

        

        public static void PrzezScalanie(int[] liczby)
        {
            if(liczby != null)
            {
              split(liczby, 0, liczby.Length - 1);
            }      
        }

        public static void split(int[] liczby, int p, int k)
        {
            if (p < k)
            {
                int srodek = (p + k) / 2;
                split(liczby, p, srodek);
                split(liczby, srodek + 1, k);
                merge (liczby, p, srodek, k);
            }
        }

        public static void merge(int[] liczby, int p, int srodek, int k)
        {
            int[] copy = new int[liczby.Length];
            liczby.CopyTo(copy, 0);

            for (int i = p, l = p, r = srodek + 1; i <= k; i++)
            {
                if (l > srodek)
                {
                    liczby[i] = copy[r];
                    r++;
                } else if (r > k)
                {
                    liczby[i] = copy[l];
                    l++;
                } else if (copy[l] < copy[r])
                {
                    liczby[i] = copy[l];
                    l++;
                } else
                {
                    liczby[i] = copy[r];
                    r++;
                }

            }
        }

        public static void PrzezZliczanie(int[] liczby) // simplified (no support for sub zero digits yet)
        {
            int myMin = liczby.Min() < 0 ? liczby.Min() : 0;
            int[] helperTab = new int[liczby.Max() + 1 - myMin];
            for (int i = 0; i < liczby.Length; i++)
            {
                helperTab[liczby[i] - myMin]++;
            }
            for(int i = 0, counter = 0; i < helperTab.Length; i++)
            {
                for(int k = 0; k < helperTab[i]; k++)
                {
                    liczby[counter] = i + myMin;
                    counter++;
                }
            }


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
