using System;

class Qs
{
    static void Qs(int[] a, int l, int h)
    {
        if (l < h)
        {
            int pI = P(a, l, h);
            Qs(a, l, pI - 1);
            Qs(a, pI + 1, h);
        }
    }

    static int P(int[] a, int l, int h)
    {
        int p = a[h];
        int i = l - 1;

        for (int j = l; j < h; j++)
        {
            if (a[j] <= p)
            {
                i++;
                S(a, i, j);
            }
        }

        S(a, i + 1, h);
        return i + 1;
    }

    static void S(int[] a, int i, int j)
    {
        int t = a[i];
        a[i] = a[j];
        a[j] = t;
    }

    static void P(int[] a)
    {
        foreach (var i in a)
        {
            C(i + " ");
        }
        C("");
    }

    static void C(object o)
    {
        Console.Write(o + " ");
    }
}