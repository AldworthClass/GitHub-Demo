namespace GitHub_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temperature;
            Console.Write("What is the tempp in celsius: ");
            temperature = Convert.ToInt32(Console.ReadLine());

            if (temperature <= 0)
                Console.WriteLine("Its freezing!");

            else if (temperature <= 15)
                Console.WriteLine("Its cool");

            else if (temperature <= 25)
                Console.WriteLine("Its Warm");
            else
                Console.WriteLine("Its Hot");
                
            



        }
    }
}