// See https://aka.ms/new-console-template for more information


using ConceptsPOO;

Console.WriteLine("POO Concepts!");
Console.WriteLine("===============");


Date date1 = new Date(2022, 2, 11);

try
{
    Console.WriteLine(new Date(2022, 2, 11));
    Console.WriteLine(new Date(1976, 6, 1));
    Console.WriteLine(new Date(1896, 12, 3));
    Console.WriteLine(new Date(2024, 2, 29));

}
catch (Exception error)
{
    Console.WriteLine(error.Message);
    
}

