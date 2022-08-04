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
    

   

