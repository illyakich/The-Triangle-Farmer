Console.WriteLine("Whats the base size of the triangle?");
float Base = Convert.ToSingle(Console.ReadLine());
Console.WriteLine("now, whats the height of the triangle?");
float height  = Convert.ToSingle(Console.ReadLine());

float Area = (Base * height) / 2;

Console.WriteLine($"the Area of the triange is {Area} ");