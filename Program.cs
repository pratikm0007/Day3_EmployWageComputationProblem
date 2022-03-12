using System;
namespace EmployWageComputationProblem
{
    class Program
    {
        /// <summary>
        /// Check Employ is Absent or Present
        /// </summary>
        static void Main(string[] args)
        {
            int forFullHrsEmploy = 1;

            //Computation to get Random value 0 & 1.
            Random random = new Random();
            int value = random.Next(2);

            if (value == forFullHrsEmploy)
            {
                Console.WriteLine("Employ is Present");
            }
            else
            {
                Console.WriteLine("Employ is Absent");
            }
        }
    }
}