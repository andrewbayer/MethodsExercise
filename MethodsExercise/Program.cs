namespace MethodsExercise
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("How old are you?");
            string userAge = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            string favAnimal = Console.ReadLine();

            Console.WriteLine("Who is your favorite band?");
            string favBand = Console.ReadLine();

            Console.WriteLine("What is your gender?");
            string userGender = Console.ReadLine();

            Console.WriteLine($"There was a {userGender} named {userName}. He was {userAge} years old.");
            Console.WriteLine($"His favorite animal is {favAnimal}, and his favorite band is {favBand}.");
            Console.WriteLine($"{userName} loves {favAnimal} and {favBand}, however, {userName} being {userAge}, has never seen either in person.");

            Console.WriteLine("Give me a number to add.");
            int num1 = int.Parse(Console.ReadLine());  

            Console.WriteLine("Give me another number to add to the first.");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"The sum is: {sum}.");

            Console.WriteLine("Give me a number to multiply.");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me another number to multiply to the first.");
            int y = int.Parse(Console.ReadLine());

            int product = Multiply(x, y);
            Console.WriteLine($"The product is: {product}.");



        }
        public static int Sum(int num1, int num2)
        {
         return num1 + num2;  

        }

        public static int Multiply(int x, int y) 
        { 
            return x * y; 
        
        }

        public static int Sum(params int[] list)
        {
            int sum = 0;    

            for (int i = 0; i < list.Length; i++)
            {
                sum = sum + list[i];
            }
            return sum;
        }

    }
}