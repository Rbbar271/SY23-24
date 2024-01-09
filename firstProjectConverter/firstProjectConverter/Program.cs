// See https://aka.ms/new-console-template for more information
Console.WriteLine("enter an amount of leters");
int liters = 0;
int.TryParse(Console.ReadLine(), out liters);
Console.WriteLine("1) in gallons  \n2) in quarts  \n3) in pints  \n4) in cups  \n5) in ounces \n 6) in tablespoons \n 7) in teaspoons \n 8) in gills");
int num1 = 0;
int.TryParse(Console.ReadLine(),out num1);
switch (num1)
{
    case 1:
        Console.WriteLine(liters * 0.264172 + "gallons");
        break;
    case 2:
        Console.WriteLine(liters * 1.05669 + "quarts");
        break;
    case 3:
        Console.WriteLine(liters * 2.11338 + "pints");
        break;
    case 4:
        Console.WriteLine(liters * 4.16667 + "cups");
        break;
    case 5:
        Console.WriteLine(liters * 33.814 + "ounces");
        break;
    case 6:
        Console.WriteLine(liters * 67.628 + "tablespoons ");
        break;
    case 7:
        Console.WriteLine(liters * 202.884 + "teaspoons");
        break;
    case 8:
        Console.WriteLine(liters * 8.45351 + "gills");
        break;

}

/*f (num1 == 1)
{

Console.WriteLine(meters* 3.28084 + "feet");
}
if (num1 == 2)
{

    Console.WriteLine(meters * 1.09361 + "yards");
}
if (num1 == 3)
{

    Console.WriteLine(meters * 39.3701 + "inch");
}
if (num1 == 4)
{

    Console.WriteLine(meters * 39.3701 + "inch");
}*/
Console.ReadLine();



