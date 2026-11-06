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

        public static void PrzezKopcowanie(int[] liczby)
        {
            for (int i = 0; i < liczby.Length; i++)
            {
                Sortowanie.Kopcuj(liczby, liczby.Length - 1 - i);
                int temp = liczby[0];
                liczby[0] = liczby[liczby.Length - 1 - i];
                liczby[liczby.Length - 1 - i] = temp;
            }
        }

        public static void Kopcuj(int[] liczby, int koniec)
        {
            for(int i = koniec; i > 0; i--)
            {
                if (liczby[i] > liczby[(i - 1) / 2])
                {
                    int temp = liczby[i];
                    liczby[i] = liczby[(i - 1) / 2];
                    liczby[(i - 1) / 2] = temp;
                }
            }
        }

        // 7 2 9 4 1 8 3 0 6 5
        public static void Szybkie(int[] liczby)
        {
            QuickSort(liczby, 0, liczby.Length - 1);
        }

        public static void QuickSort(int[] liczby, int start, int end)
        {
            int L = start, i = L - 1;
            int P = end, j = P + 1;
            int pivot = liczby[L];
            if (L < P)
            {
                while (i < j)
                {
                    while (i < j && liczby[++i] <= pivot)
                    {
                        while (i < j && liczby[--j] >= pivot)
                        {
                        }
                    }
                    Swap(liczby, i, j);
                    /*int temp = liczby[i];
                    liczby[i] = liczby[j];
                    liczby[j] = temp;*/             
                }
                QuickSort(liczby, L, j);
                QuickSort(liczby, i, P);
            }
        }


        public static int ownMin(int a, int b)
        {
            return a < b ? a : b;
        }

        public static int ownMax(int a, int b)
        {
            return a > b ? a : b;
        }

        public static void Swap(int[] tab, int i, int k)
        {
            int temp = tab[i];
            tab[i] = tab[k];
            tab[k] = temp;
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
