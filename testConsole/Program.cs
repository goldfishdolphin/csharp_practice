// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
    //   Console.Read();

      char letter; letter= 'B';
      int number; number=3;
      float body; body= 98.6f;
      double pi =3.14159;
      bool flag = false;
      string text = "This is a C# string";

      Console.WriteLine("char letter:\t" + letter);
      Console.WriteLine("int number:\t"+ number);
      Console.WriteLine("float body:\t"+ body);
      Console.WriteLine("double pi:\t"+ pi);
      Console.WriteLine("bool flag:\t"+ flag);
      Console.WriteLine("string text:\t"+ text);
      
      //Read and Display Input
      Console.Write("Please enter your name ");
      string name = Console.ReadLine();
      Console.WriteLine("Welcome "+ name +"!");

// Array
string [] cities= new string[3]{"manchester", "london", "edinburgh"};
Console.WriteLine("Second city: "+cities[1]);



// Array in int
int [] numbers= new int [10]{1,2,3,4,5,6,7,8,9,10};
Console.WriteLine("Fifth Number in Array : "+ numbers[4]);
Console.Read();