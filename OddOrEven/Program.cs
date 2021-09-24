using System;

namespace OddOrEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer: ");
            var Answer = Console.ReadLine();
            var Value = Convert.ToInt32(Answer);

            if (Value % 2 == 0){

                Console.WriteLine("The number is even!");
            } else{
                Console.WriteLine("The number is odd!");
            }
            
        }
    }
}
