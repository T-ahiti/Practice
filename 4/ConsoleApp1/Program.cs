
using System;

public static class yearName
{
   public static void Main(){

         int year;
         Console.WriteLine("Enter year:");
         year = Convert.ToInt32(Console.ReadLine());

      switch(year){
            case 1:
            Console.WriteLine("Freshman");
            break;
      
            case 2:
            Console.WriteLine("second year");
            break;
      

            case 3:
            Console.WriteLine("third year");
            break;
     
            case 4:
            Console.WriteLine("senior");
            break;
      
            default:
            Console.WriteLine("Invalid year");
            break;
        }

   }
   
}