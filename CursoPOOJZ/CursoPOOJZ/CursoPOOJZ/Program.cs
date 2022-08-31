using CursoPOOJZ;

Console.WriteLine("POO Concepts");
Console.WriteLine("========");

try
{
	Console.WriteLine(new Date(2024, 2, 29));
	Console.WriteLine(new Date(1997, 9, 23));
	Console.WriteLine(new Date(1900, 2, 7));
	Console.WriteLine(new Date(1985, 11, 31));
}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}
