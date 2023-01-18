// 001
//Write a program in C# Sharp to create a recursive function to calculate the Fibonacci number of a specific term
//---------------------------------------------------------------------------------------------------------------

//int result = Fibonacci(10); //recursive
//Console.WriteLine(result);
//int Fibonacci(int n)
//{
//    if (n <= 1)
//    {
//        return n;
//    }
//    else
//    {
//        return Fibonacci(n - 1)+Fibonacci( n - 2 );
//    }
//}

//002
//----------------------------------------------------------------------------------------------------------------
//Write a program in C# Sharp to create a recursive function to find the factorial of a given number. Go to the editor
//Test Data :
//Enter a number: 5
//Expected Output :
//The factorial of 5! is 120

//int value = Factorial(9);
//Console.WriteLine(value);

//int Factorial(int x)          // ITERATIVE METHOD         
//{
//    int sum = 1;

//    for (int i = 1; i < x; i++)                  
//    {
//        var a = x - i;
//        sum = sum * a;

//    }
//    return sum * x;
//}


//int Factorial(int x)      // RECURSIVE METHOD                              
//{
//    if (x == 0)
//    {
//        return 1;
//    }
//    else
//    {
//        return x*Factorial(x-1);
//    }
//}

//----------------------------------------------------------------------------------------------------------------

//003

//Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number. Go to the editor
//Test Data :
//Enter a number: 1234
//Expected Output :
//The sum of the digits of the number 1234 is : 10

//Console.WriteLine("Enter a number");
//int result = SumNumber(int.Parse(Console.ReadLine()));
//Console.WriteLine($"the sum of the individual digit is {result}");
//int remainder;
//int SumNumber(int x)
//{
//    int sum = 0;
//    while (x > 0)
//    {
//        remainder = x % 10;
//        sum += remainder;
//        x = x / 10;
//    }
//    return sum;
//}

// OR
//Console.WriteLine("Enter a number");
//var result = SumNumber(int.Parse(Console.ReadLine()));
//Console.WriteLine(result);
//int SumNumber(int n)
//{
//    string x = n.ToString();
//    var sum = 0;
//    for (int i = 0; i < x.Length; i++)
//    {
//        sum = sum + Convert.ToInt32(x.Substring(i,1));
//    }
//    return sum;
//   }

//----------------------------------------------------------------------------------------------------------------








