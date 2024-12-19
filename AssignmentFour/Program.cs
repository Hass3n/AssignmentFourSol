namespace AssignmentFour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Write a program that allows the user to insert an integer then print all numbers between 1 to that number.

            //Console.WriteLine("Enter Your Number");
            //int.TryParse(Console.ReadLine(), out int num);
            //for(int i=1;i<=num;i++)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region  Write a program that allows the user to insert an integer then  print a multiplication table up to 12.

            //Console.WriteLine("Enter Your number");
            //int.TryParse(Console.ReadLine(),out int num);
            //for (int i = 1;i<=12;i++)
            //{
            //    Console.WriteLine($"{i} X {num} ="+i*num);

            //}


            #endregion

            #region Write a program that allows to user to insert number then print all even numbers between 1 to this number


            //Console.WriteLine("Enter Your Number");
            //int.TryParse(Console.ReadLine(), out int num);
            //Console.Clear();
            //for(int i=1;i<num;i++)
            //{
            //    if(i%2==0)
            //        Console.WriteLine(i);
            //}
            #endregion

            #region Write a program that takes two integers then prints the power.
            //int result = 1;

            //Console.WriteLine("Enter Your base");
            //int.TryParse(Console.ReadLine(), out int numBase);

            //Console.WriteLine("Enter Your power");
            //int.TryParse(Console.ReadLine(), out int numPower);

            //for(int i=1;i<=numPower;i++)
            //{

            //    result = result * numBase;


            //}

            //Console.WriteLine(result);

            #endregion

            #region Write a program to enter marks of five subjects and calculate total, average and percentage.

            //float sum = 0.0f;

            //for(int i=1;i<=5;i++)
            //{

            //    Console.WriteLine("Enter your subject mark");
            //    int.TryParse(Console.ReadLine(), out int numScore);

            //    sum = sum + numScore;



            //}

            //Console.WriteLine($"Total marks = {sum} ");   
            //Console.WriteLine($"average marks = {(int)sum/5} ");
            //float percantage =( sum / 500) *100;
            //Console.WriteLine($"Percentage  = {(int)percantage} ");


            #endregion

            #region  Write a program to input the month number and print the number of days in that month

            //String mssg = null;

            //Console.WriteLine("Enter Your number of month");
            //String numMonth= Console.ReadLine();
            //mssg = numMonth switch
            //{

            //    "1"=> "number of Days 31",
            //    "2"=> "number of Days 29",
            //    "3"=> "number of Days 31",
            //    "4"=> "number of Days 30",
            //    "5"=> "number of Days 31",
            //    "6"=> "number of Days 30",
            //    "7"=> "number of Days 31",  
            //    "8"=> "number of Days 31",
            //    "9"=> "number of Days 30",
            //    "10"=> "number of Days 31",
            //    "11"=> "number of Days 30",
            //    "12"=> "number of Days 31",

            //};
            //Console.WriteLine(mssg);
            #endregion

            #region Write a program to create a Simple Calculator.
            //double result=0.0;
            //Console.WriteLine("Enter Your first Number");
            //int.TryParse(Console.ReadLine(), out int firstNumber);

            //Console.WriteLine("Enter Your second Number");
            //int.TryParse(Console.ReadLine(), out int secondNumber);

            //Console.WriteLine("Enter Your Operator Like (+,-,/,*)");
            //String? op=Console.ReadLine();

            //result = op switch
            //{
            //    "+" => firstNumber + secondNumber,
            //    "-"=>firstNumber-secondNumber,
            //    "*"=>firstNumber*secondNumber,
            //    "/"=>firstNumber/secondNumber,


            //};

            //Console.WriteLine(result);

            #endregion

            #region  Write a program to allow the user to enter int and print the REVERSED of it.

            //Console.WriteLine("Enter Your number");
            //String? x = Console.ReadLine();
            //for(int i=x.Length-1;i>=0;i--)
            //{
            //    Console.Write(x[i]);

            //}





            #endregion

            #region Write a program in C# Sharp to find prime numbers within a range of numbers.

            //Console.WriteLine("Input starting number of range");
            //int.TryParse(Console.ReadLine(), out int startPoint);

            //Console.WriteLine("Input end number of range");
            //int.TryParse(Console.ReadLine(), out int endPoint);

            //for (int i = startPoint; i <= endPoint; i++)
            //{

            //    if (i <= 1)
            //        continue;


            //    bool isPrime = true;

            //        for (int j = 2; j <= Math.Sqrt(i); j++)
            //        {


            //        if (i % j == 0) 
            //        {
            //            isPrime = false;

            //            break;
            //        }




            //    }
            //        if(isPrime)
            //        Console.WriteLine(i);





            //    }

            //Console.WriteLine(Math.Sqrt(36));

            #endregion

            #region Write a program in C# Sharp to convert a decimal number into binary without using an array.

            //Console.WriteLine("Enter Your number");
            //int.TryParse(Console.ReadLine(), out int num);
            //int result;
            //string numBinary = "";

            //int i = 0;
            //while(num>=1)
            //{

            //    result = num % 2;
            //    num = num / 2;

            //    numBinary = numBinary + result;
      
            //    i++;

            //}

            //// reverse Binary 

            //for (int j= numBinary.Length-1; j >= 0;j--)
            //{

            //    Console.Write(numBinary[j]);


            //}
            #endregion
        }
    }
}
