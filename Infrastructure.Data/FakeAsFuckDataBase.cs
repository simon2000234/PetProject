using System;
using System.Collections.Generic;
using System.Linq;
using Core.Entities;

namespace Infrastructure.Data
{
    public class FakeAsFuckDataBase
    {
        internal static int id = 1;

        internal static IEnumerable<Pet> listPets = makeAFewPets();

        internal static List<Pet> makeAFewPets()
        {
            List<Pet> listPets = new List<Pet>();
            var pet1 = new Pet
            {
                ID = 666,
                BirthDate = DateTime.Now,
                Price = 1,
                SoldDate = DateTime.MinValue,
                Name = "DinMor",
                Color = "Black",
                PreviousOwner = "DinFar",
                Type = "Human"
            };
            listPets.Add(pet1);
            var pet2 = new Pet
            {
                BirthDate = DateTime.MinValue,
                Color = "Pink",
                ID = 420,
                Name = "Dab Master",
                PreviousOwner = "Michael",
                Price = 69.69,
                SoldDate = DateTime.MaxValue,
                Type = "Fish"
            };
            listPets.Add(pet2);

            return listPets;
        }
    };

   
}

