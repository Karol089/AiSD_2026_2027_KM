using System;
using System.CodeDom.Compiler;
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

        public static void PrzezZliczanie(int[] liczby)
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

        public static void przezKopcowanie(int[] liczby) // do dokończenia
        {
            for(int i = liczby.Length - 1; i >= 0; i--)
            {
                while (liczby[i] > liczby[i / 2])
                {
                    int k = i + 1;
                    while (k > 1 && liczby[k - 1] > liczby[k / 2 - 1])
                    {
                        int temp = liczby[k - 1];
                        liczby[k - 1] = liczby[k / 2 - 1];
                        liczby[k / 2 - 1] = temp;
                        k = k / 2;
                    }
                }                       
            }
        }

        public static void fixHeap(int[] tab)
        {
            int i = 0;
            while (tab[i] < Sortowanie.ownMax(tab[(i + 1) * 2 - 1], tab[(i + 1) * 2]))
            {
                int temp = tab[i];
                tab[i] = tab[] // do dokończenia
            }
        }

        /*for (int k = i; k > 0; k = k / 2)
                    {
                        if (liczby[k] > liczby[k / 2])
                        {
                            int temp = liczby[k];
                            liczby[k] = liczby[k / 2];
                            liczby[k / 2] = temp;
                        }
                    }*/

        public static int ownMin(int a, int b)
        {
            return a < b ? a : b;
        }

        public static int ownMax(int a, int b)
        {
            return a > b ? a : b;
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
