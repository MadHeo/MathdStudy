using System;

namespace MethodPractice
{
    //class Calculator
    //{
        //public static int Plus (int a, int b)
        //{
        //    Console.WriteLine("Input : {0}, {1}", a, b);

        //    int result = a + b;
        //    return result;
        //}

        //int x = Program.Plus(3, 4);

        //    public static int Plus(int a, int b)
        //    {
        //        return a + b;
        //    }

        //    public static int Minus(int a, int b)
        //    {
        //        return a - b;
        //    }
        //}

        //class MainApp
        //{
        //    public static void Main()
        //    {
        //        int result = Calculator.Plus(3, 4);
        //        Console.WriteLine(result);

        //        result = Calculator.Minus(5, 2);
        //        Console.WriteLine(result);
        //    }
        //}


        //Ref Return

    //class Product
    //{
    //        private int price = 100;

    //        public ref int GetPrice()
    //        {
    //            return ref price;
    //        }

    //        public void PrintPrice()
    //        {
    //            Console.WriteLine($"Price :{price}");
    //        }
    //}
       

    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        Product carrot = new Product();
    //        ref int ref_local_price = ref carrot.GetPrice();
    //        int normal_local_price = carrot.GetPrice();

    //        carrot.PrintPrice();
    //        Console.WriteLine($"Ref Local Price :{ref_local_price}");
    //        Console.WriteLine($"Normal Local Price :{normal_local_price}");

    //        ref_local_price = 200;

    //        carrot.PrintPrice();
    //        Console.WriteLine($"Ref Local Price :{ref_local_price}");
    //        Console.WriteLine($"Normal Local Price :{normal_local_price}");
    //    }
    //}

    //출력 전용 매개 변수
    //class MainApp
    //{
    //    static void Divide(int a, int b, out int quotient, out int remainder)
    //    {
    //        quotient = a / b;
    //        remainder = a % b;
    //    }

    //    static void Main(string[] args)
    //    {
    //        int a = 20;
    //        int b = 3;

    //        Divide(a, b, out int c, out int d);

    //        Console.WriteLine($"a:{a}, b:{b}:, a/b:{c}, a%b:{d}");
    //    }
    //}

    //가변길이 매개변수
    class MainApp
    {
        static int Sum(params int[] args)
        {
            Console.Write("Summing...");

            int sum = 0;

            for(int i=0; i<args.Length; i++)
            {
                if (i > 0)
                    Console.Write(",");

                Console.Write(args[i]);

                sum += args[i];
            }

            Console.WriteLine();

            return sum;
        }

        static void Main(string[] args)
        {
            int sum = Sum(3, 4, 5, 6, 7, 8, 9, 10);

            Console.WriteLine($"Sum : {sum}");
        }
    }


}
