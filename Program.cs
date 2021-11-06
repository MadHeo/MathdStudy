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
    //class MainApp
    //{
    //    static int Sum(params int[] args)
    //    {
    //        Console.Write("Summing...");

    //        int sum = 0;

    //        for(int i=0; i<args.Length; i++)
    //        {
    //            if (i > 0)
    //                Console.Write(",");

    //            Console.Write(args[i]);

    //            sum += args[i];
    //        }

    //        Console.WriteLine();

    //        return sum;
    //    }

    //    static void Main(string[] args)
    //    {
    //        int sum = Sum(3, 4, 5, 6, 7, 8, 9, 10);

    //        Console.WriteLine($"Sum : {sum}");
    //    }
    //}


    //명명된 매개 변수
    //class MainApp
    //{
    //    static void PrintProfile(string name, string phone)
    //    {
    //        Console.WriteLine($"Name:{name}, Phone:{phone}");
    //    }
    //    static void Main(string[] args)
    //    {
    //        PrintProfile(name: "박찬호", phone: "010-123-1234");
    //        PrintProfile(phone: "010-932-3434", name: "박지성");
    //        PrintProfile("박세리","010-231-3453");
    //        PrintProfile("박상현", phone: "010-3243-6734");
    //    }
    //}

    //선택적 매개 변수
    //class MainApp
    //{
    //    static void PrintProfile(string name, string phone = "")
    //    {
    //        Console.WriteLine($"Name:{name}, Phone : {phone}");
    //    }

    //    static void Main(string[] args)
    //    {
    //        PrintProfile("태연");
    //        PrintProfile("윤아", "010-4123-4433");
    //        PrintProfile(name : "유리");
    //        PrintProfile(name: "서현", phone:"010-4123-4433");
    //    }
    //}

    //로컬 함수
    //class MainApp
    //{
    //    static string ToLowerString(string input)
    //    {
    //        var arr = input.ToCharArray();
    //        for(int i=0; i<arr.Length; i++)
    //        {
    //            arr[i] = ToLowerChar(i);
    //        }

    //        char ToLowerChar(int i)
    //        {
    //            if (arr[i] < 65 || arr[i] > 90)
    //                return arr[i];
    //            else
    //                return (char)(arr[i] + 32);
    //        }

    //        return new string(arr);
    //    }

    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine(ToLowerString("Hello!"));
    //        Console.WriteLine(ToLowerString("Good Morning."));
    //        Console.WriteLine(ToLowerString("This is C#."));
    //    }
    //}

    //문제 1
    //class MainApp
    //{
    //    static double Square(double arg)
    //    {
    //        return arg * arg;
    //    }

    //    static void Main(string[] args)
    //    {
    //        Console.Write("수를 입력하세요 :");
    //        string input = Console.ReadLine();
    //        double arg = Convert.ToDouble(input);

    //        Console.WriteLine("결과 : {0}", Square(arg));
    //    }
    //}

    //문제 2
    //class MainApp
    //{

    //    public static void Main()
    //    {
    //        double mean = 0;

    //        mean = Mean(1, 2, 3, 4, 5, mean);

    //        Console.WriteLine("평균 : {0}", mean);
    //    }

    //    public static double Mean(
    //        double a, double b, double c, double d, double e, double mean)
    //    {
    //        return (a + b + c + d + e) / 5;
    //    }

    //}

    //문제 3
    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        int a = 3;
    //        int b = 4;
    //        int resultA = 0;

    //        Plus(a, b, out resultA);

    //        Console.WriteLine("{0} + {1} = {2}", a, b, resultA);

    //        double x = 2.4;
    //        double y = 3.1;
    //        double resultB = 0;

    //        //Plus(x, y, out resultB);

    //        Console.WriteLine("{0} + {1} = {2}", x, y, resultB);
    //    }

    //    public static void Plus(int a, int b, out int c)
    //    {
    //        c = a + b;
    //    }

    //    public static void Plus(double a, double b, double c)
    //    {
    //        c = a + b;
    //    }
    //}


    //클래스 구현
    //class Cat
    //{
    //    public string Name;
    //    public string Color;

    //    public void Meow()
    //    {
    //        Console.WriteLine($"{Name} : 야옹");
    //    }
    //}

    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        Cat kitty = new Cat();
    //        kitty.Color = "하얀색";
    //        kitty.Name = "키티";
    //        kitty.Meow();
    //        Console.WriteLine($"{kitty.Name} : {kitty.Color}");

    //        //Cat nero = new Cat();
    //        //nero.Color = "검은색";
    //        //nero.Name = "네로";
    //        //nero.Meow();
    //        //Console.WriteLine($"{nero.Name} : {nero.Color}");
    //    }
    //}

    //생성자와 종료자
    //class Cat
    //{
    //    public Cat()
    //    {
    //        Name = "";
    //        Color = "";

    //    }

    //    public Cat(string _Name, string _Color)
    //    {
    //        Name = _Name;
    //        Color = _Color;
    //    }

    //    ~Cat()
    //    {
    //        Console.WriteLine($"{Name}:잘가");
    //    }

    //    public string Name;
    //    public string Color;

    //    public void Meow()
    //    {
    //        Console.WriteLine($"{Name} : 야옹");
    //    }
    //}

    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        Cat kitty = new Cat("키티", "하얀색");
    //        kitty.Meow();
    //        Console.WriteLine($"{kitty.Name} : {kitty.Color}");

    //        Cat nero = new Cat("네로", "검은색");
    //        nero.Meow();
    //        Console.WriteLine($"{nero.Name} : {nero.Color}");
    //    }
    //}


    //정적 필드와 메소
    //class Global
    //{
    //    public static int Count = 0;
    //}

    //class ClassA
    //{
    //    public ClassA()
    //    {
    //        Global.Count++;

    //    }
    //}

    //class ClassB
    //{
    //    public ClassB()
    //    {
    //        Global.Count++;
    //    }
    //}


    //class MainApp
    //{
    //    static void Main()
    //    {
    //        Console.WriteLine($"Global.Count : {Global.Count}");

    //        new ClassA();
    //        new ClassA();
    //        new ClassB();
    //        new ClassB();

    //        Console.WriteLine($"Global.Count : {Global.Count}");
    //    }
    //}

    //객체 복사하기
    //class MyClass
    //{
    //    public int MyField1;
    //    public int MyField2;


    //    public MyClass DeepCopy()
    //    {
    //        MyClass newCopy = new MyClass();
    //        newCopy.MyField1 = this.MyField1;
    //        newCopy.MyField2 = this.MyField2;

    //        return newCopy;
    //    }

    //}

    //struct MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Shallow Copy");
    //        {
    //            MyClass source = new MyClass();
    //            source.MyField1 = 10;
    //            source.MyField2 = 20;

    //            MyClass target = source;
    //            target.MyField2 = 30;

    //            Console.WriteLine("{0} {1}", source.MyField1, source.MyField2);
    //            Console.WriteLine("{0} {1}", target.MyField1, target.MyField2);
    //        }

    //        Console.WriteLine("Deep Copy");
    //        {
    //            MyClass source = new MyClass();
    //            source.MyField1 = 10;
    //            source.MyField2 = 20;

    //            MyClass target = source.DeepCopy();
    //            target.MyField2 = 30;

    //            Console.WriteLine($"{source.MyField1} {source.MyField2}");
    //            Console.WriteLine($"{target.MyField1} {target.MyField2}");
    //        }
    //    }

    //}

    //상속과 베이스
    //class Base
    //{
    //    protected string Name;
    //    public Base(string Name)
    //    {
    //        this.Name = Name;
    //        Console.WriteLine($"{this.Name}.Base()");
    //    }

    //    ~Base()
    //    {
    //            Console.WriteLine($"{this.Name}.~Base()");
    //    }

    //    public void BaseMethod()
    //    {
    //        Console.WriteLine($"{Name}.BaseMethod()");
    //    }
    //}

    //class Derived : Base
    //{
    //    public Derived(string Name) : base(Name)
    //    {
    //        Console.WriteLine($"{this.Name}.Derived()");
    //    }

    //    ~Derived()
    //    {
    //        Console.WriteLine($"{this.Name}.Derived()");
    //    }

    //    public void DerivedMethod()
    //    {
    //        Console.WriteLine($"{Name}.DerivedMethod()");
    //    }
    //}

    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        Base a = new Base("a");
    //        a.BaseMethod();

    //        Derived b = new Derived("b");
    //        b.BaseMethod();
    //        b.DerivedMethod();
    //    }
    //}

    // 기반 클래스와 파생 클래스 사이의 형식 변환, 그리고 is as
    //class Mammal
    //{
    //    public void Nurse()
    //    {
    //        Console.WriteLine("Nurse()");
    //    }
    //}

    //class Dog : Mammal
    //{
    //    public void Bark()
    //    {
    //        Console.WriteLine("Bark()");
    //    }
    //}

    //class Cat : Mammal
    //{
    //    public void Meow()
    //    {
    //        Console.WriteLine("Meow()");
    //    }
    //}

    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        Mammal mammal = new Dog();
    //        Dog dog;

    //        if(mammal is Dog)
    //        {
    //            dog = (Dog)mammal;
    //            dog.Bark();
    //        }

    //        Mammal mammal2 = new Cat();

    //        Cat cat = mammal2 as Cat;
    //        if (cat != null)
    //            cat.Meow();

    //        Cat cat2 = mammal as Cat;
    //        if (cat2 != null)
    //            cat2.Meow();
    //        else
    //            Console.WriteLine("cat2 is not a Cat");
    //    }
    //}

    //파생클래스 오버라이드
    //class ArmorSuite
    //{
    //    public virtual void Initialize()
    //    {
    //        Console.WriteLine("Armored");
    //    }
    //}

    //class IronMan : ArmorSuite
    //{
    //    public override void Initialize()
    //    {
    //        base.Initialize();
    //        Console.WriteLine("Repulsor Rays Armed");
    //    }
    //}

    //class WarMachine : ArmorSuite
    //{
    //    public override void Initialize()
    //    {
    //        base.Initialize();
    //        Console.WriteLine("Double-Barrel Cannons Armed");
    //        Console.WriteLine("Micro-Rocket Launcher Arme");
    //    }
    //}

    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Creating ArmorSuite...");

    //        ArmorSuite armorsuite = new ArmorSuite();
    //        armorsuite.Initialize();

    //        Console.WriteLine("\nCreating IronMan...");
    //        ArmorSuite ironman = new IronMan();
    //        ironman.Initialize();

    //        Console.WriteLine("\nCreating WarMachine...");
    //        ArmorSuite warmachine = new WarMachine();
    //        warmachine.Initialize();
    //    }
    //}

    //메소드 숨기기
    //class Base
    //{
    //    public void MyMethod()
    //    {
    //        Console.WriteLine("Base.MyMethod()");
    //    }
    //}

    //class Derived : Base
    //{
    //    public new void MyMethod()
    //    {
    //        Console.WriteLine("Derived.MyMethod()");
    //    }
    //}

    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        Base baseObj = new Base();
    //        baseObj.MyMethod();

    //        Derived derivedObj = new Derived();
    //        derivedObj.MyMethod();

    //        Base baseOrDerived = new Derived();
    //        baseOrDerived.MyMethod();
    //    }
    //}

    //오버라이딩 봉인하기
    //class Base
    //{

    //    public virtual void SealMe()
    //    {

    //    }
    //}

    //class Derived : Base
    //{
    //    public sealed override void SealMe()
    //    {

    //    }
    //}

    //class WantToOverride : Derived
    //{
    //    public override void SealMe()
    //    {

    //    }
    //}

    //class MainApp
    //{

    //    static void Main(string[] args)
    //    {

    //    }
    //}


    //중첩 클래스
    //class Configuration
    //{
    //    List<ItemValue> listConfig = new List<ItemValue>();

    //    public void SetConfig(string item, string value)
    //    {
    //        ItemValue iv = new ItemValue();
    //        iv.SetValue(this, item, value);
    //    }

    //    public string GetConfig(string item)
    //    {
    //        foreach (ItemValue iv in listConfig)
    //        {
    //            if (iv.GetItem() == item)
    //                return iv.GetValue();
    //        }

    //        return "";
    //    }

    //    private class ItemValue
    //    {
    //        private string item;
    //        private string value;

    //        public void SetValue(Configuration config, string item, string value)
    //        {
    //            this.item = item;
    //            this.value = value;

    //            bool found = false;
    //            for (int i = 0; i < config.listConfig.Count; i++)
    //            {
    //                if (config.listConfig[i].item == item)
    //                {
    //                    config.listConfig[i] = this;
    //                    found = true;
    //                    break; 
    //                }
    //            }

    //            if (found == false)
    //                config.listConfig.Add(this);
    //        }
    //        public string GetItem()
    //        { return item; }
    //        public string GetValue()
    //        { return value; }
    //    }
    //}



    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        Configuration config = new Configuration();
    //        config.SetConfig("Version", "V 5.0");
    //        config.SetConfig("Size", "655,324 KB");

    //        Console.WriteLine(config.GetConfig("Version"));
    //        Console.WriteLine(config.GetConfig("Size"));

    //        config.SetConfig("Version", "V 5.0.1");
    //        Console.WriteLine(config.GetConfig("Version"));

    //    }
    //}

    //14. 분할 클래스
    //15. 확장 메소드

    //16. 인터페이스의 선언


    //interface ILogger
    //{
    //    void WriteLog(string message);
    //}

    //class ConsoleLogger : ILogger
    //{
    //    public void WriteLog(string message)
    //    {
    //        Console.WriteLine(
    //            "{0} {1}",
    //            DateTime.Now.ToLocalTime(), message);

    //    }
    //}

    //class FileLogger : ILogger
    //{
    //    private StreamWriter writer;

    //    public FileLogger(string path)
    //    {
    //        writer = File.CreateText(path);
    //        writer.AutoFlush = true;
    //    }

    //    public void WriteLog(string message)
    //    {
    //        writer.WriteLine("{0} {1}", DateTime.Now.ToShortTimeString(), message);
    //    }
    //}

    //class ClimateMonitor
    //{
    //    private ILogger logger;
    //    public ClimateMonitor(ILogger logger)
    //    {
    //        this.logger = logger;
    //    }

    //    public void start()
    //    {
    //        while (true)
    //        {
    //            Console.Write("온도를 입력해주세요 : ");
    //            string temperature = Console.ReadLine();
    //            if (temperature == "")
    //                break;

    //            logger.WriteLog("현재 온도 : " + temperature);
    //        }

    //    }

    //}

    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        ClimateMonitor monitor = new ClimateMonitor(
    //            new FileLogger("MyLog.txt"));

    //        monitor.start();
    //    }
    //}


    //17. 인터페이스 자식, 부모
    //interface ILogger
    //{
    //    void WriteLog(string message);
    //}

    //interface IFormattableLogger : ILogger
    //{
    //    void Wr.iteLog(string format, params Object[] args);
    //}

    //class ConsoleLogger2 : IFormattableLogger
    //{
    //    public void WriteLog(string message)
    //    {
    //        Console.WriteLine("{0} {1}",
    //            DateTime.Now.ToLocalTime(), message);
    //    }

    //    public void WriteLog(string format, params Object[] args)
    //    {
    //        String message = String.Format(format, args);
    //        Console.WriteLine("{0} {1}",
    //            DateTime.Now.ToLocalTime(), message);
    //    }
    //}

   
    //class MainApp
    //{
    //    static void Main(string[] args)
    //    {
    //        IFormattableLogger logger = new ConsoleLogger2();
    //        logger.WriteLog("The world is not flat");
    //        logger.WriteLog("{0} + {1} = {2}", 1, 1, 2);
    //    }
    //}

}
