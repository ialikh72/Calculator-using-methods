using System;
class Cal
{
    static void Calculator(int n)
    {
       
        int[] numbers = new int[n];
        for(int i=0; i<numbers.Length; i++)
        {
            Console.WriteLine("enter {0} number:",i);
            numbers[i] =int.Parse( Console.ReadLine() );
        }
        Console.WriteLine($"enter your choice \n1-for addition \n2-for subtraction \n3-for multiplication \n4-for division. ");
        int choice=int.Parse( Console.ReadLine() );
        switch ( choice )
        {
            case 1:
                {
                    int sum = 0;
                    for(int j=0; j<numbers.Length;j++)
                    {
                        sum=sum+numbers[j];
                    }
                    Console.WriteLine("sum of numbers is {0}",sum);
                    break;
                }
            case 2:
                {
                    int subtract = numbers[0];
                    for (int j = 1; j < numbers.Length; j++)
                    {
                        subtract = subtract - numbers[j];
                    }
                    Console.WriteLine("subtraction of numbers is {0}", subtract);
                    break;
                }
            case 3:
                {
                    int product = 1;
                    for (int j = 0; j < numbers.Length; j++)
                    {
                        product = product * numbers[j];
                    }
                    Console.WriteLine("product of numbers is {0}", product);
                    break;
                }
            case 4:
                {
                    float div= numbers[0];
                    for (int j = 1; j < numbers.Length; j++)
                    {
                        if (numbers[j]==0)
                        {
                            Console.WriteLine("division by zero is not allowed");
                            return;
                        }
                        div = div / numbers[j];
                    }
                    Console.WriteLine("div of numbers is {0}", div);
                    break;
                }
            default:
                Console.WriteLine("invalid choice:");
                break;

        }

    }
    static void Main()
    {
        Console.WriteLine("how many numbers you want to perform operation:");
        int n=int.Parse( Console.ReadLine() );
        Calculator(n);
    }
}
