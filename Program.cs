// See https://aka.ms/new-console-template for more information
using System;
namespace Multilevel
{
    class GrandFather
    {
        public void Display()
        {
            Console.WriteLine("grandfather's car");
        }
    }
    class Father : GrandFather
    {
        public void Disp()
        {
            Console.WriteLine("Father's bike");
        }
    }
    class son : Father
    {
        public void Displ()
        {
            Console.WriteLine("son's cycle");
            
        }
    }

    class Multiple
    {
        static void Main(String[] args)
        {
            son s =new son();
            s.Displ();
            s.Disp();
            s.Display();
            

        }
    }
}

class Compile
{
    public void student(string name, int age)
    {
        Console.WriteLine("Name  ->" + name + "   age->" + age);
    }
    public void student(string name, int age, double mbNo)
    {
        Console.WriteLine("Name ->" + name + "   age->" + age + "   " +
            "mobile No->" + mbNo);
    }
}
class main
{
    static void Main(string[] args)
    {
        Compile c = new Compile();
        c.student("manish", 25);
        c.student("ajay", 25, 9096328684);

    }
}


using System;
class vehicle
{
    public void disp()
    {
        Console.WriteLine("two and four wheeler vehicle");
    }
}
class Bike : vehicle
{
    public void display()
    {
        Console.WriteLine("Two wheeler");
    }
}
class car : vehicle
{
    public void Four()
    {
        Console.WriteLine("Four wheeler");
    }
}
class main
{
    static void Main(string[] args)
    {
        car car = new car();
        car.disp();
        car.Four();
        Bike bike = new Bike();
        bike.disp();
        bike.display();
    }
}


using System;

interface Vehicle
{

    void speedUp(int a);
    void applyBrakes(int a);
}
class Bicycle : Vehicle
{
    int speed;


    public void speedUp(int increment)
    {
        speed = speed + increment;
        Console.WriteLine("incremented speed  " + speed);
    }
    public void applyBrakes(int decrement)
    {
        speed = speed - decrement;
        Console.WriteLine("decremented speed " + speed);
    }


}
class Bike : Vehicle
{
    int speed;

    public void speedUp(int increment)
    {
        speed = speed + increment;
        Console.WriteLine("incremented speed  " + speed);
    }
    public void applyBrakes(int decrement)
    {
        speed = speed - decrement;
        Console.WriteLine("decremented speed " + speed);
    }


}
class sag
{
    static void Main(String[] args)
    {


        Bicycle bicycle = new Bicycle();
        Console.WriteLine("Bicycle present state :");
        bicycle.speedUp(3);
        bicycle.applyBrakes(1);

        Bike bike = new Bike();
        Console.WriteLine("Bike present state :");
        bike.speedUp(4);
        bike.applyBrakes(3);



    }
}

class Rbi
{
    public virtual void IntrestPercentage()
    {
        Console.WriteLine("15% intrest/y");
    }
}
class Sbi : Rbi
{
    public override void IntrestPercentage()
    {
        Console.WriteLine("5% intrest/y");
    }

}
class main
{
    static void Main(String[] args)
    {
        //Sbi sc = new Sbi();
        Rbi rb = new Rbi();
        // sc.IntrestPercentage();
        //Rbi i = new Sbi();

        rb.IntrestPercentage();
        rb
            .IntrestPercentage();

    }

}


using System;

class Father
{
    public void Disp()
    {
        Console.WriteLine("Father is eating");
    }
}
class son : Father
{
    public void Diplay()
    {
        Console.WriteLine("son is eating");
    }
}
class main
{
    static void Main(string[] args)
    {
        son s = new son();
        s.Diplay();
        s.Disp();
    }
}


class Encapsulation
{
    string name;
    double code;
    public void setdetails(string name, double code)
    {
        this.name = name;
        this.code = code;
    }
    public void Getdetails()
    {
        Console.WriteLine("The name is  " + name + " and code is  " + code);
    }
}

class sagar
{
    static void Main()
    {
        Encapsulation e = new Encapsulation();
        e.setdetails("Kalpita", 1234);
        e.Getdetails();
    }
}


