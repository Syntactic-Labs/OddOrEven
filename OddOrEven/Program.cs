using System;

namespace OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {



            //This take all the numbers from 1 to 50 and add only the number divisable by 5 OR 7
            var total = 0;
            for (int idx = 1; idx <= 50; idx++) //paras that guide the for loop AKA (where to start ; where to stop ; what increment or ammount to approach your stop point)
            {   //creates the conditions 
                if (idx % 5 == 0 || idx % 7 == 0)      //both conditions can be seperate if statements by connecting them with continue
                    total = total + idx;
            }
            Console.WriteLine($"The total is {total} ");
            //===============================================================================================================================
            Console.WriteLine("1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, ");
            //==============================================================================================================================
            for (int idx = 1; idx <= 25; idx++)
            {
                //for loop paras guide 1 to 25 by increments of 1 while Console.Write Prints as they execute
                Console.Write($"{idx}, ");
            }
            Console.WriteLine();
            //================================================================================================================================
            //var comma outside the loop give var a diffrent value temperaraly and espablisish a new value in the loop
            var comma = "";
            for (int idx = 1; idx <= 25; idx++)
            {
                Console.Write($"{comma} {idx}");
                comma = ",";
            }
            //===================================================================================================================================
            for (var idx = 0; idx < 5; idx++)
            {
                Console.WriteLine("Enter an integer: ");
                var Answer = Console.ReadLine();
                var Value = Convert.ToInt32(Answer);

                if (Value % 2 == 0)
                {

                    Console.WriteLine("The number is even!");
                }
                else
                {
                    Console.WriteLine("The number is odd!");
                }
            }
        }
    }
}
