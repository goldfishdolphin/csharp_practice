// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//   Console.Read();

char letter; letter = 'B';
int number; number = 3;
float body; body = 98.6f;
double pi = 3.14159;
bool flag = false;
string text = "This is a C# string";

Console.WriteLine("char letter:\t" + letter);
Console.WriteLine("int number:\t" + number);
Console.WriteLine("float body:\t" + body);
Console.WriteLine("double pi:\t" + pi);
Console.WriteLine("bool flag:\t" + flag);
Console.WriteLine("string text:\t" + text);

//Read and Display Input
Console.Write("Please enter your name ");
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
string name = Console.ReadLine();
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
Console.WriteLine("Welcome " + name + "!");

// Array
string[] cities = new string[3] { "manchester", "london", "edinburgh" };
Console.WriteLine("Second city: " + cities[1]);



// Array in int
int[] numbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
Console.WriteLine("Fifth Number in Array : " + numbers[4]);


int[,] coord = new int[2, 3] { { -1, 2, 3 }, { 0, 2, 3 } };
Console.WriteLine("Coordinate(0,0 ): " + coord[0, 0]);
Console.WriteLine("Coordinate(1,2 ): " + coord[1, 2]);


// Arithmetic
int a = 18;
int b = 4;

Console.WriteLine("addition:\t" + (a + b));
Console.WriteLine("subraction:\t" + (a - b));
Console.WriteLine("multiplication:\t" + (a * b));
Console.WriteLine("division:\t" + (a / b));
Console.WriteLine("modulus:\t" + (a % b));

Console.WriteLine("postfix increment:\t" + (a++));
Console.WriteLine("postfix result:\t" + a);

Console.WriteLine("prefix increment:\t" + (++a));
Console.WriteLine("prefix result:\t" + a);


int n = 0, num = 0, max = 1;
char cap = 'B', low = 'b';
Console.WriteLine("Testing equality");
Console.WriteLine("\t (0==0):\t" + (n == num));
Console.WriteLine("\t (A==a):\t" + (cap == low));

Console.WriteLine("Testing inequality");
Console.WriteLine("\t (0!=1):\t" + (n != max));

Console.WriteLine("Greater");
Console.WriteLine("\t (0>1): \t" + (n > max));

Console.WriteLine("Less");
Console.WriteLine("\t (0<1): \t" + (n < max));
