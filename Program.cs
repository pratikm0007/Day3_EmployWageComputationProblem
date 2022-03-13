using System;
namespace EmployWageComputationProblem
{
    class Program
    {
        /// <summary>
        /// Add Part time employ and wage.
        /// </summary>
        static void Main(string[] args)
        {
            int forFullHrsEmploy = 1;
            int forPartTimeHrsEmploy = 0;
            int wagePerHrs = 20;

            int hrs = 0;
            int empWage = 0;

            //Computation to get Random value 0 & 1.
            Random random = new Random();
            int value = random.Next(2);

            if (value == forFullHrsEmploy)
            {
                Console.WriteLine("Employ is FullTime Present");
                hrs = 8;
            }
            else if (value == forPartTimeHrsEmploy)
            {
                Console.WriteLine("Employ is PartTime Present");
                hrs = 4;
            }
            else
            {
                Console.WriteLine("Employ is Absent");
                hrs = 0;
            }
            empWage = wagePerHrs * hrs;
            Console.WriteLine("Employ wage is : {0}", +empWage);
        }
    }
}