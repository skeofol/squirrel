using System;

using System.Linq;

namespace ооп
{
   class squirrel
    {
        public string Name;
        public nut[] nuts;
        private int i;
        public hollow hollow1;

        public squirrel(nut[] momsNuts,hollow hollow1)
        {
            this.nuts = momsNuts;
            ShowNuts();
            this.hollow1 = hollow1;
        }
        public void ShowNuts()
        {
            Console.WriteLine("У меня есть орехи вот таких цветов:");
            foreach (var nut in nuts)
            {
                Console.WriteLine(nut.color);
            }

        }
        public void EatNut()
        {
            Console.WriteLine($"Я скушала орех {nuts[0].color}");

            nuts = nuts.Skip(1).ToArray();


            Console.WriteLine($"У меня остались...");

            ShowNuts();

        }

        public void FindNut()
        {
            nut nut = new nut();
            nut.color = Color.Green;
            Console.WriteLine($"Я нашла орех {nut.color}");

            nuts = nuts.Append(nut).ToArray();
            Console.WriteLine($"Теперь у меня вот столько орехов...");
            ShowNuts();

        }
        public void PutInHallow(nut nut, hollow hollow)
        {
            hollow.nuts = hollow.nuts.Append(nut).ToArray();

            Console.WriteLine($"Я положила орех в дупло");
                }
            public void CheckNut()
        {
            if (i > 1)
            {
                nuts = nuts.Skip(1).ToArray();
            }

            else
            {
                Console.WriteLine($"У меня 0 орехов!!!");
                FindNut();
                
            }
            
        }
    }
}