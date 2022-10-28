/*
float sideA = 10.5f;//todo numero flotante debe llevar un f al final de la cifra
int sideB = 20;

//Nota: es posible acer operaciones entre enteros y flotantes siempre y cuando la variable recesptora sea flotante
float area = sideA * sideB;

Console.WriteLine("The rectangle area is: " + area);
*/

Console.WriteLine("Enter Measures: \nEnter the value of the side A: ");
float sideA = float.Parse(Console.ReadLine());

Console.WriteLine("Enter the value of the side B: ");
float sideB = float.Parse(Console.ReadLine());

float area = sideA * sideB;
Console.WriteLine("The rectangle area is: " + area);
