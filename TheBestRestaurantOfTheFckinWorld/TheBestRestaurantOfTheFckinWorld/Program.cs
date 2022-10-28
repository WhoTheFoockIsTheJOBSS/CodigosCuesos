
string[] consumers = new string[10] {"Jobss","Yeyo", "Chaaarls", "Yuki", "Jimbo", "Juli", "Gunter", "Perry", "Kevn", "Loid"};
int currentIndexConsumers = 0;
string userType;
string consumer;

Console.WriteLine("Welcome to the best Restaurant of the Fckin world B)");

while (currentIndexConsumers == consumers.Length) 
{
    /*
    if (currentIndexConsumers == consumers.Length)
    {
        Console.WriteLine("The best restaurant of the FCKIN world is full");
        Environment.Exit(0);
    }
    */

    Console.WriteLine("Are you already Registered?\ntype any option: \ny= yes, n= no");
    userType = Console.ReadLine();

    if (userType == "y")
    {
        Console.WriteLine("Enter your UserName: ");
        consumer = Console.ReadLine();

        int index = Array.IndexOf(consumers, consumer);
        if (index != -1)
        {
            Console.WriteLine($"Hi {consumer}! You are already registered in the best Restaurant of the Fckin world B)");
        }
        else
        {
            Console.WriteLine("UserName didn't find. You have registrate");
        }
    }
    else if (userType == "n")
    {
        Console.WriteLine("Please Write an UserName: ");
        consumers[currentIndexConsumers] = Console.ReadLine();

        Console.WriteLine($"Ypur user has been saved successfully\n ypur user name is: {consumers[currentIndexConsumers]}");

        currentIndexConsumers++;
    }
    else
    {
        Console.WriteLine("Type y or n");
    }
}

Console.WriteLine("The best restaurant of the FCKIN world is full\nThese ara the Guests to the dinner: ");
//lista de consumers
int auxindex = 0;

foreach(string element in consumers)
{
    Console.WriteLine($"{auxindex+1} and user name {consumers[auxindex]}");
    auxindex++;
}
Environment.Exit(0);

