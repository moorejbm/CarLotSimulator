using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property

            CarLot carvana = new CarLot();

            var car1 = new Car(2014, "Dodge", "Challenger", "Hummm", "Beep", true);
            var car2 = new Car(2003, "Jeep", "Wrangler", "Vroom", "Beep Beep", true);
            //var car3 = new Car();
            //{
            //        Year = 2018,
            //        Make = "Honda",
            //        Model ="Accord",
            //        EngineNoise = "Vroom",
            //        HonkNoise = "Beep",
            //        IsDrivable = true,
            //};
            carvana.Cars.Add(car1);
            carvana.Cars.Add(car2);
            //carvana.Cars.Add(car3);


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console


            foreach (var car in carvana.Cars)
            {
                Console.WriteLine(".............................");
                Console.WriteLine(car.Make);
                Console.WriteLine(car.Model);
                Console.WriteLine(car.Year);
                Console.WriteLine(car.EngineNoise);
                Console.WriteLine(car.HonkNoise);

                if (car.IsDrivable)
                {
                    Console.WriteLine("This car can drive");
                }

            }
        }
    }
}
