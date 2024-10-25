
using System;

public static class numbers
{
    public static void Main()
    {
        int mark;
        char grade;

        Console.Write("Enter your numeric mark =>");
        mark = Convert.ToInt32(Console.ReadLine());

        if( mark >=80 && mark <= 100)
            grade = 'A';
        else if(mark >= 70)
            grade = 'B';
        else if ( mark >= 60)
            grade = 'C';
        else if ( mark >= 50)
            grade = 'D';
        else if (mark >=40)
            grade = 'E';
        else if( mark >= 30)
            grade = 'F';

        else{
            Console.WriteLine("Invalid marks");
            grade = 'X';
        }

        Console.WriteLine("The letter grade for {0} is {1}", mark , grade);
        Console.ReadLine();
            
    }
}