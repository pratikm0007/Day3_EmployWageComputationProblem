using System;
namespace EmployWageComputationProblem
{
    class Program
    {

        public const int forFullHrsEmploy = 1;
        public const int forPartTimeHrsEmploy = 0;
        public const int wagePerHrs = 20;
        /// <summary>
        /// Add Part time employ and wage.
        /// </summary>
        static void Main(string[] args)
        {
            int hrs = 0;
            int empWage = 0;

            //Computation to get Random value 0 & 1.
            Random random = new Random();
            int value = random.Next(3);

            switch (value)
            {
                case forFullHrsEmploy:
                    Console.WriteLine("Employ is FullTime Present");
                    hrs = 8;
                    break;
                case forPartTimeHrsEmploy:
                    Console.WriteLine("Employ is PartTime Present");
                    hrs = 4;
                    break;
                default:
                    Console.WriteLine("Employ is Absent");
                    hrs = 0;
                    break;
            }
            empWage = wagePerHrs * hrs;
            Console.WriteLine("Employ wage is : {0}", +empWage);
        }
    }
}