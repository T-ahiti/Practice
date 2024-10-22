using System;

public static class PetFood
{
  public static void Main()
    {
        char foodGrade;
        
        Console.WriteLine("Our pet food is available in three grades: A, B, and C");
        Console.WriteLine("Which do you want pricing for =>");
        foodGrade = Convert.ToChar(Console.ReadLine());
    


        switch(foodGrade)
        {
            case 'A':
                Console.WriteLine("Grade A pet food costs $30.");
                break;
            case 'B':
            Console.WriteLine("Grade B pet food costs $20");
                break;
            case 'C':
            Console.WriteLine("Grade B pet food costs $10");
                break; 
        }

    }
}