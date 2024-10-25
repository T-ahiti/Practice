
using System;

public static class MovieDiscount{
    public static void Main(){
        int age;
        char rating; 
        const int CHILD_AGE = 12;
        const int SENIOR_AGE = 65;
        Console.WriteLine("Discount applies when age is {0} or >=65 and rating is {1}", CHILD_AGE, SENIOR_AGE);
        
        Console.WriteLine("Enter age:");
        age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter rating:");
        rating = Convert.ToChar(Console.ReadLine());

        if((age <= CHILD_AGE || age >= SENIOR_AGE)&& rating == 'G')
            Console.WriteLine("Discount applies");
        else 
            Console.WriteLine("Full Price");
        Console.ReadLine();
    }
}