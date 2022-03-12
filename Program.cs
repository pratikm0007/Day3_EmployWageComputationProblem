using System;
namespace EmployWageComputationProblem
{
    class Program
    {
        /// <summary>
        /// Check Daily Employ wage.
        /// </summary>
        static void Main(string[] args)
        {
            int forFullHrsEmploy = 1;
            int wagePerHrs = 20;

            int hrs = 0;
            int empWage = 0;

            //Computation to get Random value 0 & 1.
            Random random = new Random();
            int value = random.Next(2);

            if (value == forFullHrsEmploy)
            {
                Console.WriteLine("Employ is Present");
                hrs = 8;
            }
            else
            {
                Console.WriteLine("Employ is Absent");
                hrs = 0;
            }
            empWage = wagePerHrs * hrs;
            Console.WriteLine("Daily Employ wage is : {0}",+ empWage);
        }
    }
}