using System;
namespace EmployWageComputationProblem
{
    //Employ Wage For Multiple Company.
    class Program
    {
        public const int ForFullHrsEmploy = 1;
        public const int ForPartTimeHrsEmploy = 0;
        /// <summary>
        /// Calculate Wage Till condition of 100 Hours or 20 Day meets.
        /// </summary>
        public static void CalMonthlyWage(string Company, int WagePerHrs,int WorkDayInMonth,int WorkHrsInMonth)
        {
            int hrs = 0;
            int totalEmployhrs = 0;
            int totalWorkDayInMonth = 0;
            int totalEmploywage = 0;

            while (totalWorkDayInMonth < WorkDayInMonth && totalEmployhrs < WorkHrsInMonth)
            {
                totalWorkDayInMonth++;
                //Computation to get Random value 0 & 1.
                Random random = new Random();
                int value = random.Next(3);

                switch (value)
                {
                    case ForFullHrsEmploy:
                        Console.WriteLine("Employ is FullTime Present");
                        hrs = 8;
                        break;
                    case ForPartTimeHrsEmploy:
                        Console.WriteLine("Employ is PartTime Present");
                        hrs = 4;
                        break;
                    default:
                        Console.WriteLine("Employ is Absent");
                        hrs = 0;
                        break;
                }
                totalEmployhrs += hrs;
                Console.WriteLine("Day : {0} , Employ Hours : {1} ", +totalWorkDayInMonth, totalEmployhrs);

            }
            totalEmploywage = totalEmployhrs * WagePerHrs;
            Console.WriteLine("Employ  wage for Company: " +Company +" is : " +totalEmploywage);

        }
        public static void Main(string[] args)
        {
            Program.CalMonthlyWage("TATA",500,22,120 );
            Program.CalMonthlyWage("POWERGRID", 600, 24, 150);
        }
    }
}