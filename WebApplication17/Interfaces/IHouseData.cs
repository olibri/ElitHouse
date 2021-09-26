﻿using System.Collections.Generic;
using WebApplication17.Data.Models;

namespace WebApplication17.Interfaces
{
    public interface IHouseData
    {
        IEnumerable<House> GetHouse();
        void AddHouse(House house);
        void RemoveHouse(int houseId);

    }
}
