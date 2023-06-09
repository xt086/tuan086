using System;

namespace VuongXuanTuan_2020604294_proj53
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length of array: ");
            int length = int.Parse(Console.ReadLine());
            TimUSCLN[] array = new TimUSCLN[length];
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Enter element {0}", i);
                array[i] = new TimUSCLN();
                array[i].Input();
            }
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Element {0}", i);
                array[i].Output();
                set.Add(array[i].Find());
            }
            foreach (var item in set)
            {
                Console.Write("Elements have GCD = {0}: ", item);
                for (int j = 0; j < length; j++)
                {
                    if (array[j].Find() == item)
                    {
                        Console.Write("{0}, ", j);
                    }
                }
                Console.Write("\n");
            }
        }
    }
    class TimUSCLN
    {
        int sothu1, sothu2;
        public int SoThu1
        {
            get { return sothu1; }
            set { sothu1 = value; }
        }
        public int SoThu2
        {
            get { return sothu2; }
            set { sothu2 = value; }
        }
        public TimUSCLN(int a, int b)
        {
            SoThu2 = b;
            SoThu1 = a;
        }
        public TimUSCLN()
        {
            sothu1 = 0;
            sothu2 = 0;
        }
        public int Find()
        {
            while (SoThu1 * SoThu2 != 0)
            {
                if (SoThu1 > SoThu2)
                {
                    SoThu1 %= SoThu2;
                }
                else
                {
                    SoThu2 %= SoThu1;
                }
            }
            return SoThu2 + SoThu1;
        }
        public void Input()
        {
            Console.Write("Enter first number: ");
            SoThu1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            SoThu2 = int.Parse(Console.ReadLine());
        }
        public void Output()
        {
            Console.WriteLine("First number: {0}", SoThu1);
            Console.WriteLine("Second number: {0}", SoThu2);
            Console.WriteLine("GCD: {0}", this.Find());
        }
    }
}
