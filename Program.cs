using System;
namespace EmployWageComputationProblem
{
    class Program
    {
        /// <summary>
        /// Calculate Monthly Wage
        /// </summary>
        static void CalMonthlyWage()
        {
            const int forFullHrsEmploy = 1;
            const int forPartTimeHrsEmploy = 0;
            const int wagePerHrs = 20;
            const int workDayInMonth = 20;

            int hrs = 0;
            int empWage = 0;
            int monthWage = 0;

            for (int day = 0; day < workDayInMonth; day++)
            {
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
                monthWage += empWage;
            }
            Console.WriteLine("Employ Monthly wage is : {0}", +monthWage);
        }
        static void Main(string[] args)
        {

            Program.CalMonthlyWage();

        }
    }
}