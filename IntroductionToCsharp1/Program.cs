using System;

class Progmram
{
    static void Main()
    {
   
        sbyte sb = 0;

        Console.WriteLine("Min sbyte = {0}", sbyte.MinValue);
        Console.WriteLine("Max sbyte = {0}", sbyte.MaxValue);

        byte b = 0;

        Console.WriteLine("Min byte = {0}", byte.MinValue);
        Console.WriteLine("Max byte = {0}", byte.MaxValue);

        short sh = 0;

        Console.WriteLine("Min short = {0}", short.MinValue);
        Console.WriteLine("Max short = {0}", short.MaxValue);

        ushort ush = 0;

        Console.WriteLine("Min ushort = {0}", ushort.MinValue);
        Console.WriteLine("Max ushort = {0}", ushort.MaxValue);

        int i = 0;

        Console.WriteLine("Min int = {0}", int.MinValue);
        Console.WriteLine("Max int = {0}", int.MaxValue);

        uint ui = 0;

        Console.WriteLine("Min uint = {0}", uint.MinValue);
        Console.WriteLine("Max uint = {0}", uint.MaxValue);

        long l = 0;

        Console.WriteLine("Min long = {0}", long.MinValue);
        Console.WriteLine("Max long = {0}", long.MaxValue);

        ulong ul = 0;

        Console.WriteLine("Min ulong = {0}", ulong.MinValue);
        Console.WriteLine("Max ulong = {0}", ulong.MaxValue);

        int intvalue = 1;


        Console.WriteLine("Min intiger value = {0}", int.MinValue);
        Console.WriteLine("Max intiger value = {0}", int.MaxValue);

        double d = 123.222422433;
        Console.WriteLine(d);


        //jesli damy integer dla wartosci po przecinku, wówczas wyskoczy błąd
        //int integerd = 123.222422433;
        //Console.WriteLine(d);

        Console.ReadKey();

    }
};