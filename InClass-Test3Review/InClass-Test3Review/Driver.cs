using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass_Test3Review
{
    public class Driver
    {
        public static void Main()
        {
            int[] myNumbers = { 4, 7, 2 };

            Console.WriteLine(myNumbers[0]);
            Console.WriteLine();

            foreach(int num in myNumbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            for (int i = 0; i < myNumbers.Length; i++)
            {
                Console.WriteLine(myNumbers[i]);
            }
            Console.WriteLine();

            int[,] myNumbers2D = { 
                                   //c0 c1 c2
                                    { 2, 3, 7 }, //row 0
                                    { 8, 3, 2 }  //row 1
                                 };

            Console.WriteLine(myNumbers2D[1, 2]); //row index 1, col index 2 -> value 2
            Console.WriteLine();

            foreach(int num in myNumbers2D)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            for (int row = 0; row < myNumbers2D.GetLength(0); row++)
            {
                for(int col = 0; col < myNumbers2D.GetLength(1); col++)
                {
                    Console.WriteLine(myNumbers2D[row, col]);
                }
            }
            Console.WriteLine();

            for (int row = 0; row < myNumbers2D.GetLength(0); row++)
            {
                for (int col = 0; col < myNumbers2D.GetLength(1); col++)
                {
                    Console.Write(myNumbers2D[row, col] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            List<int> numList = new List<int>();
            Console.WriteLine($"Co: {numList.Count}; Ca: {numList.Capacity}");

            numList.Add(1);
            Console.WriteLine($"Co: {numList.Count}; Ca: {numList.Capacity}");

            numList.Add(7);
            Console.WriteLine($"Co: {numList.Count}; Ca: {numList.Capacity}");

            numList.Add(8);
            Console.WriteLine($"Co: {numList.Count}; Ca: {numList.Capacity}");

            numList.Add(3);
            Console.WriteLine($"Co: {numList.Count}; Ca: {numList.Capacity}");

            //numList.Capacity = 2; //throws an exception because co <= ca

            numList.Capacity = 100;
            Console.WriteLine($"Co: {numList.Count}; Ca: {numList.Capacity}");
            Console.WriteLine();

            //numList: 1 7 8 3
            //indices: 0 1 2 3
            foreach(int num in numList)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            //numList: 1 7 0 8 3
            //indices: 0 1 2 3 4
            numList.Insert(2, 0);
            foreach (int num in numList)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            //Random
            Random r = new Random();

            int myVal = r.Next(); //0 to 2bil (max integer)
            int myVal2 = r.Next(10); //0, 1, 2, ..., 8, 9  max is exclusive
            int myVal3 = r.Next(3, 10); //3, 4, 5, ..., 8, 9  min is inclusive, max is exclusive
            double myVal4 = r.NextDouble(); //0.0 - 1.0  0.0 is inclusive, 1.0 is exclusive

            int myVal5 = r.Next(10) + 3; //3, 4, 5, 6, 7, 8, 9, 10, 11, 12  addition shifts the range
            int myVal6 = r.Next(10) * 2; //0, 2, 4, 6, 8, 10, 12, 14, 16, 18  multiplication expands the range
            int myVal7 = (r.Next(10) * 2) + 3; //3, 5, 7, 9, 11, 13, 15, 17, 19, 21
            int myVal8 = (r.Next(10) + 3) * 2; //6, 8, 10, 12, 14, 16, 18, 20, 22, 24

            Person p = new Person();
            
            try
            {
                Console.WriteLine("Please enter your age:");
                int age = int.Parse(Console.ReadLine());
                p.Age = age;
            }
            catch(FormatException e)
            {
                Console.WriteLine("Age must be an integer.");
            }
            catch(AgeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Something else went wrong.");
            }
        }
    }
}
