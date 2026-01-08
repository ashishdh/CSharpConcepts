using System;

namespace OOPSConcepts
{
    class Calculator
    {
        public int Add(int a, int b) => a + b;
        public int Add(int a, int b, int c) => a + b + c;
        public double Add(double a, double b) => a + b;
    }


    class Animal
    {
        public virtual void Speak() => Console.WriteLine("Animal makes a sound");
    }

    class Dog : Animal
    {
        public override void Speak() => Console.WriteLine("Dog barks");
    }

    class Cat : Animal
    {
        public override void Speak() => Console.WriteLine("Cat meows");
    }

    

    class Vehicle
    {
        public virtual void Start() => Console.WriteLine("Vehicle starting");
    }

    class Car : Vehicle
    {
        public override void Start() => Console.WriteLine("Car starts with key");
    }

    class Bike : Vehicle
    {
        public override void Start() => Console.WriteLine("Bike starts with kick");
    }
    
    abstract class Shape
    {
        public abstract double CalculateArea();
    }

    class Rectangle : Shape
    {
        public double Width = 5;
        public double Height = 4;
        public override double CalculateArea() => Width * Height;
    }

    class Circle : Shape
    {
        public double Radius = 3;
        public override double CalculateArea() => Math.PI * Radius * Radius;
    }

   
    // Exposed runner so the central startup can call this demo
    internal static class PolymorphismDemo
    {
        public static void Run()
        {
            Console.WriteLine("========= POLYMORPHISM DEMO =========\n");

            // 1️⃣ Overloading
            Calculator calc = new Calculator();
            Console.WriteLine("Overloading:");
            Console.WriteLine(calc.Add(2, 3));
            Console.WriteLine(calc.Add(2, 3, 4));
            Console.WriteLine(calc.Add(2.5, 3.5));
            Console.WriteLine();

            // 2️⃣ Overriding
            Console.WriteLine("Overriding:");
            Animal animal1 = new Dog();
            Animal animal2 = new Cat();
            animal1.Speak();
            animal2.Speak();
            Console.WriteLine();

            // 3️⃣ Base ref -> derived object
            Console.WriteLine("Base reference pointing to derived object:");
            Vehicle v1 = new Car();
            Vehicle v2 = new Bike();
            v1.Start();
            v2.Start();
            Console.WriteLine();

            // 4️⃣ Abstract class polymorphism
            Console.WriteLine("Abstract class polymorphism:");
            Shape shape1 = new Rectangle();
            Shape shape2 = new Circle();
            Console.WriteLine($"Rectangle Area: {shape1.CalculateArea()}");
            Console.WriteLine($"Circle Area: {shape2.CalculateArea()}");
            Console.WriteLine();

            Console.WriteLine("========= END POLYMORPHISM =========\n");
            // Do not pause here — central runner will handle final pause.
        }
    }
}
