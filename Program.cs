using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            float length;
            float width;
            float height;
            float perimeter;
            float area;
            float volume;
            bool calcAgain;

            do
            {
                Console.WriteLine("Welcome to the room calculator.");
                Console.WriteLine("\nPlease enter the length of the room:");
                length = float.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the width of the room:");
                width = float.Parse(Console.ReadLine());
                Console.WriteLine("Please enter the height of the room:");
                height = float.Parse(Console.ReadLine());

                perimeter = 2 * (length + width);
                area = length * width;
                volume = area * height;

                Console.WriteLine("\nPerimeter: " + perimeter);
                Console.WriteLine("Area: " + area);
                Console.WriteLine("Volume: " + volume);

                Console.WriteLine("\nContinue?(y/n)");
                char input = char.Parse(Console.ReadLine());
                if(char.ToLower(input) == 'y')
                {
                    calcAgain = true;
                }
                else
                {
                    calcAgain = false;
                }

               
            } while (calcAgain);
        }
    }
}
