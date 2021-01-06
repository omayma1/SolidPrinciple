using System;

public class Class1
{
    class Program
    {
        static void Main(string[] args)
        {
            //The orange class could not replace the Apple class without altering the program output
            Apple apple = new Orange();
            //The GetColor() is occerridden by Orange class so it will return that Apple is orange
            Debug.WriteLine(apple.GetColor());
        }
    }
    public class Apple
    {
        public virtual string GetColor()
        {
            return "Red";
        }
    }
    public class Orange : Apple
    {
        public override string GetColor()
        {
            return "Orange";
        }
    }
}
