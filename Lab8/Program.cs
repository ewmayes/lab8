using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to Batting Average Calculator");
            Console.WriteLine();
            Console.WriteLine("Enter are the number of batters?");

            int[] ar = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int batters = int.Parse(Console.ReadLine());
            if (ar.Contains(batters))

            {


                double[][] AB = new double[batters][];

                int atBats = 0;

                for (int i = 0; i < batters; i++)
                {
                    Console.WriteLine("Enter number of times at bat:");
                    atBats = int.Parse(Console.ReadLine());
                    //int[] ValidAr = { 1, 2, 3, 4 };

                    //if (ValidAr.Contains(atBats))

                        //{
                        AB[i] = new double[atBats];

                        for (int r = 0; r < atBats; r++)
                        {
                            Console.WriteLine("Result for at-bat");
                            Console.WriteLine("0=out, 1=single, 2=double, 3=triple, 4=home run");
                        //AB[i][r] = int.Parse(Console.ReadLine()); 
                        int Outcome = int.Parse(Console.ReadLine());
                            int[] ValidAB = { 0, 1, 2, 3, 4 };
                        if (ValidAB.Contains(Outcome))
                        {
                            AB[i][r] = Outcome;
                        }
                        else
                            Console.WriteLine("enter a correct outcome");
                    }

                        Console.WriteLine("");
                        Console.WriteLine("");

                        Console.WriteLine("Batting average: " + string.Format("{0:0.000}", BattingAverage(atBats, NumberOfHits(AB, i, atBats))));
                        Console.WriteLine("Slugging percentage: " + string.Format("{0:0.000}", Slugging(atBats, TotalBases(AB, i, atBats))));

                    //} else
                    //    Console.WriteLine("enter valid at-bat outcome");
                }
            }
            else
                Console.WriteLine("try again");
        }

        static public decimal BattingAverage(int AB, decimal Hits)
        {
            decimal BA = Hits / AB;
            return BA;
        }

        static public double Slugging(int AB, double Bases)
        {
            double SP = Bases / AB;
            return SP;
        }

        static public decimal NumberOfHits(double[][] AB, int batter, int atBats)
        {
            decimal Hits = 0;
            //for (int i = 0; i < AB[batter][i]; i++)
            for (int i = 0; i < atBats; i++)
            {

                if (AB[batter][i] > 0)
                {
                    Hits++;
                }
            }
            return Hits;
        }

        static public double TotalBases(double[][] AB, int batter, int atBats)
        {
            double Bases = 0;
            for(int i = 0; i < atBats; i++)
            {

                {
                     Bases += AB[batter][i];
                }
            }
            return Bases;
        }


    }
}
