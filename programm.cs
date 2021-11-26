using System;

using System.Linq;

namespace ооп
{
    class Program
    {
        static void Main(string[] args)
        {
            nut nut1 = new nut();
            nut nut2 = new nut();
            nut1.color = Color.Brown;
            nut2.color = Color.LightBrown;
            nut[] nuts = new[] { nut1, nut2 };
            for (int i = 0; i < nuts.Length; i++)
                Console.WriteLine("Item number " + i + ": " + nuts[i]);
            nut[] nutHallow = new[] { nut1, nut2 };
            for (int x = 0; x < nuts.Length; x++)
                Console.WriteLine("Item number " + x + ": " + nuts[x]);

            squirrel Tim = new squirrel(nuts);
            Tim.EatNut();
            squirrel Bob = new squirrel();
            hollow Myhollow = new hollow();
            nut nut = Tim.nuts[Tim.nuts.Length - 1];
            Tim.PutInHallow(nut,Myhollow);
            hollow hollow1 = new hollow();


        }

    }
}