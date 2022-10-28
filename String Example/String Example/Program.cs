
namespace StringExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int height = 175;
            int age = 22;
            string name = "Jobss Lamar";
            string information = "The resquested info is: " +
                "\nUser name " + name + 
                "\nUser age " + age + 
                "\nUser height " + height;

            Console.WriteLine(information);
        }
    }
}