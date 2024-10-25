
using System;

public static class AverageMarks
{
    public static void Main(){
        int numbers, num;
        double average, total=0;

        Console.WriteLine("Enter the number of marks (+ve) =>");
        numbers = Convert.ToInt32(Console.ReadLine());

    for(int i=0; i<numbers; ++i){
        Console.WriteLine("Enter a mark =>");
        num = Convert.ToInt32(Console.ReadLine());
        total = total + num;
    }
     average = total / (1.0 * numbers);
     Console.WriteLine("the average is {0}", average);
    }
}