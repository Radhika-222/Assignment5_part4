using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_part4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an array of integers with a minimum size of 5
        int[] myRArray = new int[5];

            // Populate the array with random integer values
            Random random = new Random();
            for (int i = 0; i < myRArray.Length; i++)
            {
                myRArray[i] = random.Next(1, 101); // Generates random values between 1 and 100
            }

            // Calculate and display the sum of the elements
            int sum = 0;
            foreach (int num in myRArray)
            {
                sum += num;
            }
            Console.WriteLine($"Sum: {sum}");

            // Calculate and display the average of the elements
            double average = (double)sum / myRArray.Length;
            Console.WriteLine($"Average: {average}");
            Console.ReadKey();
        }
        
    }
}
    

