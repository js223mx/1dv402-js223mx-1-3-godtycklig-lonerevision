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
            numberOfSalaries = ReadInt("Ange antal löner att mata in: ");


        }

        static private void ProcessSalaries(int count)
        {

        }

        static private int ReadInt(string prompt)
        {
            
            string tempovari = null;

            while (true)
            {
                Console.Write(prompt);

                tempovari = Console.ReadLine();
                return int.Parse(tempovari);
            }
        }

    }
}
