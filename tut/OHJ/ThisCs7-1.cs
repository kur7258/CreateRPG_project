using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisCs7_1
{
    class Cat
    {
        public string Name;
        public string Color;

        public void Meow()
        {
            Console.WriteLine($"{Name} : 멍멍");
        }

        public Cat()
        {
            Name = "";
            Color = "";
        }

        public Cat(string _Name, string _Color)
        {
            Name = _Name;
            Color = _Color;
        }
        ~Cat()//끝나면 이거출력
        {
            Console.WriteLine($"{Name}야 잘가");//항상 마지막에 오는듯...
        }
    }

    class Global
    {
        public static int Count = 0;
    }
    class ClassA
    {
        public ClassA()
        {
            Global.Count++;
        }
    }
    class ClassB
    {
        public ClassB()
        {
            Global.Count++;
        }
    }

    class Employee
    {
        private string Name;
        private string Position;

        public void SetName(string Name)
        {             //    /
            this.Name =  Name;//둘다 다른 Name
        }

        public string GetName()
        {
            return Name;
        }

        public void SetPosition(string Position)
        {
            this.Position = Position;
        }

        public string GetPosition()
        {
            return this.Position;
        }
    }
    class MyClass
    {
        public int MyField1;
        public int MyField2;
        int a, b, c;

        public MyClass DeepCopy()
        {
            MyClass newCopy = new MyClass();
            newCopy.MyField1 = this.MyField1;
            newCopy.MyField2 = this.MyField2;

            return newCopy;
        }

        public MyClass()
        {
            this.a = 4324;
            Console.WriteLine($"MyClass({a})");
        }

        public MyClass(int b) : this()
        {
            this.b = b;
            Console.WriteLine($"MyClass({b})");
        }

        public MyClass(int b, int c) : this(b)
        {
            this.c = c;
            Console.WriteLine($"MyClass({b}, {c})");
        }
        public void PrintFields()
        {
            Console.WriteLine($"a : {a}, b : {b}, c : {c}");
        }
    }

    class WaterHeater
    {
        protected int temperature;

        public void SetTemperature(int temperature)
        {
            if(temperature < -5 || temperature >42)
            {
                throw new Exception("온도초과");
            }

            this.temperature = temperature;
        }

        //초과 안 하면 internal덕에 이거 출력하면서 온도출력
        internal void TurnOnWater()
        {
            Console.WriteLine($"Turn on water : {temperature}");
        }
    }

    class Base
    {
        protected string Name;
        public Base(string Name)
        {
            this.Name = Name;
            Console.WriteLine($"{this.Name}.Base()");
        }

        //마지막으로 출력된 순
        ~Base()
        {
            Console.WriteLine($"{this.Name}.~Base()");
        }

        public void BaseMethod()
        {
            Console.WriteLine($"{this.Name}.BaseMethod()");
        }
    }

    class Derived : Base
    {
        public Derived(string Name) : base(Name)
        {
            Console.WriteLine($"{this.Name}.Derived()");
        }
        
        ~Derived()
        {
            Console.WriteLine($"{this.Name}.~Derived()");
        }

        public void DerivedMEthod()
        {
            Console.WriteLine($"{Name}.DerivedMethod()");
        }
    }

    class Mammal
    {
        public void Nurse()
        {
            Console.WriteLine("Nurse()");
        }
    }
    class Dog : Mammal
    {
        public void Bark()
        {
            Console.WriteLine("Bark()");
        }
    }
    class Ccat : Mammal
    {
        public void Meow()
        {
            Console.WriteLine("Meow()");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cat kitty = new Cat("키티", "하얀색");//Name, Color
            kitty.Meow();
            Console.WriteLine($"{kitty.Name} : {kitty.Color}");

            Cat nero = new Cat("네로", "검은색");//Name, Color
            nero.Meow();
            Console.WriteLine($"{nero.Name} : {nero.Color}");

            Console.WriteLine();

            Console.WriteLine($"Global.Count : {Global.Count}");

            new ClassA();
            new ClassA();
            new ClassB();
            new ClassB();

            Console.WriteLine($"Global.Count : {Global.Count}");

            Console.WriteLine();

            Console.WriteLine("Shallow Copy");
            {
                MyClass source = new MyClass();
                source.MyField1 = 10;
                source.MyField2 = 20;

                MyClass target = source;
                target.MyField2 = 30;

                Console.WriteLine($"{source.MyField1} {source.MyField2}");
                Console.WriteLine($"{target.MyField1} {target.MyField2}");
            }

            Console.WriteLine("Deep Copy");
            {
                MyClass source = new MyClass();
                source.MyField1 = 10;
                source.MyField2 = 20;

                MyClass target = source.DeepCopy();
                target.MyField2 = 30;

                Console.WriteLine($"{source.MyField1} {source.MyField2}");
                Console.WriteLine($"{target.MyField1} {target.MyField2}");

                Console.WriteLine();

                Employee pooh = new Employee();
                pooh.SetName("Pooh");
                pooh.SetPosition("Waiter");
                Console.WriteLine($"{pooh.GetName()} {pooh.GetPosition()}");

                Employee tigger = new Employee();
                tigger.SetName("Tigger");
                tigger.SetPosition("Cleaner");
                Console.WriteLine($"{tigger.GetName()} {tigger.GetPosition()}");

                Console.WriteLine();

                MyClass a = new MyClass();
                a.PrintFields();
                Console.WriteLine();

                MyClass b = new MyClass(1);
                b.PrintFields();
                Console.WriteLine();

                MyClass c = new MyClass(10, 20);
                c.PrintFields();

                Console.WriteLine();

                try
                {
                    WaterHeater heater = new WaterHeater();
                    heater.SetTemperature(20);
                    heater.TurnOnWater();

                    heater.SetTemperature(-2);
                    heater.TurnOnWater();

                    heater.SetTemperature(50);
                    heater.TurnOnWater();
                }
                //온도 초과된거 있으면 메세지 출력하고 멈춤
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.WriteLine();

            Base aa = new Base("aa");
            aa.BaseMethod();

            Derived bb = new Derived("bb");
            bb.BaseMethod();
            bb.DerivedMEthod();

            Console.WriteLine();

            Mammal mammal = new Dog();
            Dog dog;

            if(mammal is Dog)
            {
                dog = (Dog)mammal;
                dog.Bark();
            }

            Mammal mammal2 = new Ccat();

            Ccat cat = mammal2 as Ccat; //mammal2가Ccat아니면 null
            if (cat != null)
                cat.Meow();

            Ccat cat2 = mammal as Ccat;//mammal가Ccat아니면 null
            if (cat2 != null)
                cat2.Meow();
            else
                Console.WriteLine("cat2 is not a Cat");
        }
    }
}
