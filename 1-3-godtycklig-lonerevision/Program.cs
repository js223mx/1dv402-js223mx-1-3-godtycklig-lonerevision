using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_3_godtycklig_lonerevision
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSalaries = 0;
            do
            {
                Console.Clear();

                numberOfSalaries = ReadInt("Ange antal löner att mata in: ");
                Console.WriteLine();

                if (numberOfSalaries >= 2)
                {
                    ProcessSalaries(numberOfSalaries);
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write("Du måste mata in minst två löner för att kunna göra en beräkning!");
                    Console.ResetColor();
                }
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Tryck ned tangent för ny beräkning - Esc avslutar.");
                Console.ResetColor();

            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

        }

        static void ProcessSalaries(int count)
        {
            int medianSalary;
            int wageDistribution;
            double averageSalary;
            int[] salaries = new int[count];
            int[] unsortedSalaries = new int[count];

            salaries = new int[count];

            for (int i = 0; i < count; i++)
            {
                salaries[i] = ReadInt(string.Format("Ange lön nummer  {0}:", i + 1));
            }
            Console.WriteLine("-----------------------------------------------------");

            Array.Copy(salaries, unsortedSalaries, count);
            Array.Sort(salaries);

            //kollar så det är jämt antal löner
            if (count % 2 == 0)
            {
                //medianlönen om det är jämt antal löner
                medianSalary = (salaries[(count / 2) - 1] + salaries[(count / 2)]) / 2;
            }
            else
            {
                //medianlönen om det är ojämt antal löner
                medianSalary = salaries[(count - 1) / 2];
            }
            Console.WriteLine("Medianlönen:     {0:c0}", medianSalary);

            //Medellönen
            averageSalary = salaries.Average();
            Console.WriteLine("Medellönen:      {0:c0}", averageSalary);

            //Lönespridningen
            wageDistribution = salaries.Max() - salaries.Min();
            Console.WriteLine("Lönespridningen:  {0:c0}", wageDistribution);

            Console.Write("-------------------------------------------------------");
            Console.WriteLine();

            for (int i = 1; i <= count; i++)
            {
                Console.Write(" {0, 5} ", unsortedSalaries[i - 1]);
                if (i % 3 == 0)
                {
                    Console.WriteLine();
                }
            }
        }

        static private int ReadInt(string prompt)
        {

            string tempovari;

            while (true)
            {
                try
                {
                    Console.Write(prompt);
                    tempovari = Console.ReadLine();
                    return int.Parse(tempovari);
                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write("Fel vid inmatning, ange ett heltal: ");
                    Console.ResetColor();
                }


            }
        }

    }
}
