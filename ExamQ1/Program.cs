namespace ExamQ1;

class Program
{
    // Part A:
    private static int value1 = 42;
    private static float value2 = 11.11f;
    private static double value3 = 17.1717171717d;
    private static char value4 = 'X';
    private static bool value5 = false;
    private static string value6 = "This is a test.";
    
    static void Main(string[] args)
    {
    
        // Part B:
        Console.WriteLine($"{value1} is {value1.GetType()}");
        Console.WriteLine($"{value2} is {value2.GetType()}");
        Console.WriteLine($"{value3} is {value3.GetType()}");
        Console.WriteLine($"{value4} is {value4.GetType()}");
        Console.WriteLine($"{value5} is {value5.GetType()}");
        Console.WriteLine($"{value6} is {value6.GetType()}");

        // Part C:
        int partC = value1 + (int)value2 + (int)value3;
        Console.WriteLine($"Part C: sum of values is {partC}");
        
        // Part D:
        int[] partD = new[] { 4, 8, 15, 16, 23 };
        int sumD = 0;
        foreach (int i in partD)
        {
            sumD += i;
        }
        
        Console.WriteLine($"Part D: sum of values is {sumD}");
        
        // Part E:
        Console.WriteLine($"The largest value from D is {FindMax(partD)}");

    }

    static int FindMax(int[] arr)
    {
        int max = arr[0];
        int i = 0;
        
        while (i < arr.Length)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }

            i++;
        }

        return max;
    }
}