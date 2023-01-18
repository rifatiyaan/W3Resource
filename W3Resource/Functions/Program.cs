//                                                  001
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

//int Factorial(int x)                      // ITERATIVE METHOD         
//{
//    int sum = 1;

//    for (int i = 1; i < x; i++)                  
//    {
//        var a = x - i;
//        sum = sum * a;

//    }
//    return sum * x;
//}


//int Factorial(int x)                     // RECURSIVE METHOD                              
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
