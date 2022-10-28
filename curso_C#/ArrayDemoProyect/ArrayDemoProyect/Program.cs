
string[] coffeTypes; 
float[] coffeValues;

coffeTypes = new string[] { "Expresso", "Largo", "Filtrado", "LAte" }; //4
coffeValues = new float[] { 1.2f, 1.5f, 5.0f, 5.5f };

coffeTypes[1] = "Lungo";

for (int i = 0; i < coffeTypes.Length; i++)
    Console.WriteLine(coffeTypes[i] + " coffe $" + coffeValues[i]);
