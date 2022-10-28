
bool continueProgramSoftwareExecution = true;

while(continueProgramSoftwareExecution == true)
{
    Console.WriteLine("Continue with the software running? type y= yes, or n= no");
    string confirmation = Console.ReadLine();

    if (confirmation == "y")
        Console.WriteLine("infinito");
    else if (confirmation == "n") { 
        Console.WriteLine("It'll be the last time the software is running. Good bye :)");
        continueProgramSoftwareExecution = false;
    }
    else
        Console.WriteLine("Chose a valid oprtion ");
}