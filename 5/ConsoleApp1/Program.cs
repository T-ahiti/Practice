
using System;

public static class PetFood
{
    public static void Main()
    {
        char foodGrade;

        Console.WriteLine("Enter the grade of your food:");
        foodGrade = Convert.ToChar(Console.ReadLine());

        switch(char.ToUpper(foodGrade)){
            case 'A':
            Console.WriteLine("the food is high quality");
            break;

            case 'B':
            Console.WriteLine("this food is medium quality");
            break;

            case 'C':
            Console.WriteLine("this is low quality food");
            break;

            default:
            Console.WriteLine("this grade is invalid");
            break;
        }
    }
}