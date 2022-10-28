
//operadores logicos:
//    && = and
//    || = or 
//    ! = diferente
//

/*
bool v1 = true;
bool v2 = false;
bool v3 = false;

Console.WriteLine("bool v1 = true\nbool v2 = false\nbool v3 = false");

bool result1 = v1 && v2 && v3;
Console.WriteLine("The result from logocal operator AND && is: " + result1);

bool result2 = v1 || v2 || v3;
Console.WriteLine("The result from logocal operator OR || is: " + result2);

bool result3 = !(v1 && v2 && v3);
Console.WriteLine("The result from logocal operator DIFERENT ! is: " + result3);
*/

/*
x == y; x es igual a y?
x != y; x es diferente a y?
x > y; x es mayor que y?
x < y; x es menor que y?
x >= y; x es mayor o igual a y?
x <= y; x es menor o igual a x?
*/

int v1 = 3;
int v2 = 18;
int v3 = -18;

Console.WriteLine("bool v1 = 3\nbool v2 = 18\nbool v3 = -18\n");

bool result0 = v1 == v2;
Console.WriteLine("The result of " + v1 + " == " + v2 + " is: " + result0);
bool result1 = v1 != v3;
Console.WriteLine("The result of " + v1 + " != " + v3 + " is: " + result1);
bool result2 = v3 > v1;
Console.WriteLine("The result of " + v3 + " > " + v1 + " is: " + result2);
bool result3 = v2 < v3;
Console.WriteLine("The result of " + v2 + " < " + v3 + " is: " + result3);
bool result4 = v1 >= v2;
Console.WriteLine("The result of " + v1 + " >= " + v2 + " is: " + result4);
bool result5 = v3 <= v2;
Console.WriteLine("The result of " + v3 + " <= " + v2 + " is: " + result5);
