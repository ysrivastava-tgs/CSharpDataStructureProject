using System;

namespace CSharDataStructureProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            do
            {
                Console.WriteLine("1.Show Sorted Data\n2.Search");
                int option = Convert.ToInt32(Console.ReadLine());
                if(option==1)
                {
                    RainbowSchool.SortedDetails();
                }
                else
                {
                    Console.WriteLine("Input name ");
                    RainbowSchool.Search(Console.ReadLine());
                }
                Console.WriteLine("Want to continue?(Type yes/no)");
                input = Console.ReadLine();

            } while (input.Equals("yes"));

        }
    }
}
