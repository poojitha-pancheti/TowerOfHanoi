using System;

namespace TowerOfHanoi
{
    class Program
    {
        public static void Hanoi(int n,char source,char temp,char dest)
        {
            if (n == 1)
            {

                Console.WriteLine("Move disk" + n + "from" + source + "-->" + dest);
                return;
            }
            Hanoi(n-1,source, dest, temp);
            Console.WriteLine("Move disk" + n + "from" + source + "-->" + temp);
            Hanoi(n - 1, temp, source, dest);

        }
        
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter number of disks:");
            n = Convert.ToInt32(Console.ReadLine());
            Hanoi(n, 'A', 'B', 'C');
        }
    }
}
