using System.Drawing;

namespace MethodsExercise
{
    class Program
    {
        public static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }
        public static int Multiply(int num1, int num2, int num3) 
        {
            return num1 *num2 * num3;
        }
            
        static void Main(string[] args)
        {
            var amountOfCars = Sum(2, 6);
            var blar = Multiply(60, 2, 4);

            //-------------- Exercise 1 ------------------------
            //Nmae: Micheal 
            //Favorite Color: Blue
            //Favorite Animal: Walrus
            //Favorite Band:  The Beatles

            Console.WriteLine("Hello new student, what is your first name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"{userName} is an awesome name! Tell the class your favorite color.");
            var color = Console.ReadLine();

            Console.WriteLine($"Nice {userName}, {color} is a beautiful color. The class would love to know the name of your favorite Animal?");
            var animal = Console.ReadLine();

            Console.WriteLine($"{animal} is a unique choice. Lastly tell the class your favorite band's name?");
            var band = Console.ReadLine();

            Console.WriteLine($"Students let's welcome {userName} to the class, as he just shared that {color}, {animal}, {band}, as his favorite color, animal and band.");

            //--------------- Exercise 2 ------------------------------
        }
    }
}
