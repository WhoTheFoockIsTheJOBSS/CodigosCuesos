
List<string> tacoShopoingList = new List<string>();

tacoShopoingList.Add("Cinco tacos de suadero");
tacoShopoingList.Add("Cuatro tacos de tripa");
tacoShopoingList.Add("Cinco tacos de pastor");
tacoShopoingList.Add("Cuatro Coca colas");

for (int i = 0; i < tacoShopoingList.Count; i++)
{
    Console.WriteLine(tacoShopoingList[i]);
}

//tacoShopoingList.Remove("Cinco tacos de suadero"); hace lo mismo que .RemoveAt(index)
tacoShopoingList.RemoveAt(0);


for (int i = 0; i < tacoShopoingList.Count; i++)
{
    Console.WriteLine(tacoShopoingList[i]);
}