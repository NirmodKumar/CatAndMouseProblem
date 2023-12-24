// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var x = 2;
var y = 5;
var z = 4;

var response = CatAndMouse(x, y, z);

Console.WriteLine(response);

static string CatAndMouse(int x, int y, int z)
{
    var catA = Math.Abs(x - z);
    var catB = Math.Abs(y - z);
    var response = catA < catB ? "Cat A" : "Cat B";

    if (catA == catB)
    {
        response = "Mouse C";
    }

    return response;
}

Console.ReadLine();