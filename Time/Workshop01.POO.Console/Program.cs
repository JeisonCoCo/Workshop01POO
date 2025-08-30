
using POO.Workshop01.Core;

internal class Program
{
    private static void Main(string[] args)
    {
        var t1 = new Time();
        var t2 = new Time(14);
        var t3 = new Time(9, 34);
        var t4 = new Time(19, 45, 56);
        var t5 = new Time(23, 3, 45, 678);

        var times = new List<Time> { t1, t2, t3, t4, t5 };


        Console.WriteLine(t1.ToString());
        Console.WriteLine(t2.ToString());
        Console.WriteLine(t3.ToString());
        Console.WriteLine(t4.ToString());
        Console.WriteLine(t5.ToString());
        foreach (Time time in times)
        {
            Console.WriteLine($"Time: {time}");
            Console.WriteLine($"\tMilliseconds: {time.ToMilliseconds,15:N0}");
            Console.WriteLine($"\tSeconds     : {time.ToSeconds,15:N0}");
            Console.WriteLine($"\tMinutes     : {time.ToMinutes,15:N0}");
            Console.WriteLine($"\tAdd         : {time.ToAdd(t3),15:N0}");
            Console.WriteLine($"\tIs Other day: {time.IsOtherday(t4)}");
            Console.WriteLine();
        }
    }
}