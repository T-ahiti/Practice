
using System;

public static class AveragesForStudents{
    public static void Main(){
        int csCount = 0, mathCount = 0, busCount=0;
        double csTotal =0, mathTotal = 0, busTotal = 0;
        double markVal;
        char deptCode;

        Console.WriteLine("Enter a department code: 'C' or 'c' for Computer Science,'M' or 'm' for Math, 'B' or 'b' for Business Admin, or enter 'Q' or 'q' to quit => ");
        deptCode = char.ToUpper(Console.ReadLine()[0]);

        while(char.ToUpper(deptCode) != 'Q'){

            if( deptCode == 'C' || deptCode == 'M' || deptCode == 'B'){
                Console.WriteLine("Enter the mark (0 - 100):=> ");
                markVal = Convert.ToDouble(Console.ReadLine());
                if(markVal>=0 && markVal<=100){
                   if(deptCode == 'C'){
                     csTotal += markVal;
                     csCount ++;
                    }
                   if(deptCode == 'M'){
                      mathTotal += markVal;
                      mathCount ++;
                    }
                    if(deptCode == 'B'){
                      busTotal += markVal;
                      busCount ++;
                    }
                }
                else{
                    Console.WriteLine("invalid mark, please enter a valued mark");
                }
            }
            else {
                Console.WriteLine("Invalid department code");
            }

            Console.WriteLine("Enter department code 'C' for Computer Science, 'M' for Math, 'B' for Business Admin, or 'Q' to quit: ");
            deptCode = char.ToUpper(Console.ReadLine()[0]);

        }

        Console.WriteLine("Computer Science average: " + (csCount > 0 ? (csTotal / csCount).ToString("F1") : "No Data"));
        Console.WriteLine("Mathematics average: " + (mathCount > 0 ? (mathTotal / mathCount).ToString("F1") : "No Data"));
        Console.WriteLine("Business Administration average: " + (busCount > 0 ? (busTotal / busCount).ToString("F1") : "No Data"));
    }
}