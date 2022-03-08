using System;

namespace abstractClass
{
    abstract class Person
    {
        public string Name;
        public void name()
        {
            Console.WriteLine("Nikita");
        }
    }

    interface Department
    {
        void calculateArea(int length, int breadth);
        
    }
    public class Person2 : Department
    {
        public void calculateArea(int l, int b)
        {
        int area = l * b;
        Console.WriteLine(area);
           
        }
    }
    internal class Program:Person
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.Name = "Rojan";
            obj.name();
            Console.WriteLine("My name is "+ obj.Name);

            Person2 p = new Person2();
            p.calculateArea(20, 20);
     
            Console.ReadLine();
        }
    }
}
