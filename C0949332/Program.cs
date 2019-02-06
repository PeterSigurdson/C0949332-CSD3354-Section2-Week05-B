using System;

namespace C0949332
{
    class Program
    {
        static void Main(string[] args)
        {
            // LinkdLists and NODES
            Console.WriteLine("Hello World!");
        }
    }

    class Dog
    {
        public static int NumberOfDogs = 0;
        public Dog()
        {
            // A constructor is Method
            // that Creates OBJECTS from a TYPE
            Dog.NumberOfDogs++;
        }
        public String DogName;
        public String DogBreed;
        public Dog nextDog;
    }

    class LinkedList
    {
        public Dog Peanut = new Dog();
        public Dog Fifi = new Dog();
        public Dog Jordan = new Dog();
        public Dog Fido = new Dog();

        public void run()
        {
            Peanut.DogName = "Peanut";
            Peanut.DogBreed = "Bichon";

            Fifi.DogName = "Peanut";
            Fifi.DogBreed = "Bichon";

            Jordan.DogName = "Peanut";
            Jordan.DogBreed = "Bichon";

            Fido.DogName = "Peanut";
            Fido.DogBreed = "Bichon";

        }

    }
}
