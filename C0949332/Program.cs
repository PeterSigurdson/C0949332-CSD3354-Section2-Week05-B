using System;

namespace C0949332
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList a = new LinkedList();
            a.run();
            a.WalkOverTheList();
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
        public Dog current;
        public Dog Head;
        public Dog Peanut = new Dog();
        public Dog Fifi = new Dog();
        public Dog Jordan = new Dog();
        public Dog Fido = new Dog();

        public void run()
        {
            Head = Peanut;
            Peanut.DogName = "Peanut";
            Peanut.DogBreed = "Bichon";

            Fifi.DogName = "Fifi";
            Fifi.DogBreed = "Poodle";

            Jordan.DogName = "Jordan";
            Jordan.DogBreed = "germansheppard";

            Fido.DogName = "Fido";
            Fido.DogBreed = "Beagle";

        }

        public void WalkOverTheList()
        {
            current = Head;
            while (true)
            {
                Console.WriteLine(current.DogName);
                current = current.nextDog;

            }
        }

    }
}
