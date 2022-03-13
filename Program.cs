using System;
namespace EmployWageComputationProblem
{
    class Program
    {
        /// <summary>
        /// Calculate Wage Till condition of 100 Hours or 20 Day meets.
        /// </summary>
        static void Main(string[] args)
        {
            const int forFullHrsEmploy = 1;
            const int forPartTimeHrsEmploy = 0;
            const int wagePerHrs = 20;
            const int workDayInMonth = 20;
            const int workHrsInMonth = 100;

            int hrs = 0;
            int totalEmployhrs = 0;
            int totalWorkDayInMonth = 0;
            int totalEmploywage = 0;

            while (totalWorkDayInMonth < workDayInMonth && totalEmployhrs < workHrsInMonth)
            {
                totalWorkDayInMonth++;
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
                totalEmployhrs+= hrs;
                Console.WriteLine("Day : {0} , Employ Hours : {1} ",+totalWorkDayInMonth,totalEmployhrs);
                
            }
            totalEmploywage = totalEmployhrs * wagePerHrs;
            Console.WriteLine("Employ  wage is : {0}", +totalEmploywage);

            
        }
    }
}