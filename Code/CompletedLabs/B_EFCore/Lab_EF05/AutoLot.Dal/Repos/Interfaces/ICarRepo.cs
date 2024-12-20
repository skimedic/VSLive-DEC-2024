﻿// Copyright Information
// ==================================
// AutoLot9 - AutoLot.Dal - ICarRepo.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2024/11/24
// ==================================

namespace AutoLot.Dal.Repos.Interfaces;

public interface ICarRepo : IBaseRepo<Car>
{
    IEnumerable<Car> GetAllBy(int makeId);
    string GetPetName(int id);
    int SetAllDrivableCarsColorAndMakeId(string color, int makeId);
    int DeleteNonDrivableCars();
}
