﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vet_Clinic
{
    public class Cat : IAnimal
    {
        public Cat(string name, DateTime birthday, string breed, double weight, string medicalHistory, string color, string favoriteToy)
        {
            Name = name;
            Birthday = birthday;
            Breed = breed;
            Weight = weight;
            MedicalHistory = medicalHistory;
            Color = color;
            FavoriteToy = favoriteToy;
            Status = Status.NotAdopted;
        }

        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public string Breed { get; set; }
        public double Weight { get; set; }
        public string MedicalHistory { get; set; }
        public string Color { get; set; }
        public string FavoriteToy { get; set; }
        public string Image { get; set; }
        public Status Status { get; set; }
    }

    public enum Status
    {
        NotAdopted,
        Adopted
    }
}
