using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Core.ApplicationService
{
    public interface IPetService
    {
        List<Pet> GetAllPets();

        Pet GetPet(int id);

        void AddPet(Pet pet);

        void RemovePet(int id);
    }
}
