﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {
        public Car()
        {
            CarLot.numberOfCars++;
            //ClassName.StaticMember
        }

        public Car(int year, string make, string model, string engineNoise, string honkNoise, bool isDrivable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = engineNoise;
            HonkNoise = honkNoise;
            IsDrivable = isDrivable;
        }
    
         //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
         public int Year { get; set; }
         public string Make { get; set; }
         public string Model { get; set; }
         public string EngineNoise { get; set; }
        public string HonkNoise { get; set; }
         public bool IsDrivable { get; set; }



}
}
