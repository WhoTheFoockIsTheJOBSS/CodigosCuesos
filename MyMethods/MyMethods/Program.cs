using System;

internal class MyMethods
{
    public void IntegerAddition(int a, int b)
    {
        int addition = a + b;
        Console.WriteLine("El resultado es: " + addition);
    }

    public void IntegerSubstract( int a, int b)
    {
        int substract = a - b;
        Console.WriteLine("El resultado es: " + substract);
    }

    public int IntegerProduct(int a, int b)
    {
        int product = a * b;
        return product;
    }

    public float FloatDivition(float a, float b)
    {
        return a / b;
    }    
    private static void Main(string[] args)
    {
        MyMethods MyProgram = new MyMethods();

        MyProgram.IntegerAddition(3, 6);
        MyProgram.IntegerSubstract(3, 6);

        int product = MyProgram.IntegerProduct(3, 6);
        Console.WriteLine("El producto es: " + product);

        float divition = MyProgram.FloatDivition(3.0f, 6.9f);
        Console.WriteLine("La division es: " + divition);
    }
}