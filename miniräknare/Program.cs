using System;

namespace miniräknare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("mata in tal 1:");
            int inmatat = int.Parse(Console.ReadLine());
            Console.WriteLine(inmatat);
            Console.Write("mata in tal 2: ");
            int inmatat2  = int.Parse (Console.ReadLine());
            int summa = inmatat + inmatat2;
            Console.WriteLine("summan: "+ summa);
            int produkt = inmatat * inmatat2;
            Console.WriteLine("produkt: "+ produkt);
            int kvot = inmatat / inmatat2;
            Console.WriteLine("kvot: " + kvot);
            Console.ReadLine();
        }
    }
}
