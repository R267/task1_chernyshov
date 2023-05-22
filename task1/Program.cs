using System;
class Program
{
    public static void Main()
    {
        int n = 40;
        int a = 0;
        int b = 1;
        Console.Write("Перші {0} чисел Фібаначі", n);
        Console.Write(a + ", ");
        for (var i = 0; i < n; i++)
        {
            Console.Write(b + ", ");
            int next = a + b;
            a = b;
            b = next;
        }
        Console.Read();
    }
}