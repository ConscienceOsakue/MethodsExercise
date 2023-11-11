using System.Drawing;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //-------------- Exercise 1 ---------------
            //Nmae: Micheal 
            //Favorite Color: Blue
            //Favorite Animal: Walrus
            //Favorite Band:  The Beatles
 
            Console.WriteLine("Hello new student, what is your first name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"{userName} is an awesome name! Tell the class your favorite color.");
            var color = Console.ReadLine();

            Console.WriteLine($"Nice, {color} is a beautiful color. The class would love to know the name of your favorite Animal?");
            var animal = Console.ReadLine();

            Console.WriteLine($"{animal} is a unique choice. Lastly let the class your favorite band's name?");
            var band = Console.ReadLine();
        }
    }
}
