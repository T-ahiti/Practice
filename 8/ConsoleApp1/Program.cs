
using System;

public static class MarkAverage{
    public static void Main(){
        int totalMarks, numberOfSubjects;
        double average;

        Console.WriteLine("Enter the number of time you want to repeat the procedure:");
        int repetation = Convert.ToInt32(Console.ReadLine());
        
        for(int i = 0; i < repetation; i++){

            Console.WriteLine("enter the number:");
            totalMarks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the number of subjects:");
            numberOfSubjects = Convert.ToInt32(Console.ReadLine());

            average = (double)totalMarks / numberOfSubjects;  
            Console.WriteLine("Your average score is: {0}", average);
        }
        
      
    }
}
