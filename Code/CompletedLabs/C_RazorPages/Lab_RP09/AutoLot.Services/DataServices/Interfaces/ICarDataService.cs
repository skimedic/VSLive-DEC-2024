// Copyright Information
// ==================================
// AutoLot9 - AutoLot.Services - ICarDataService.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2024/11/28
// ==================================

namespace AutoLot.Services.DataServices.Interfaces;

public interface ICarDataService : IDataServiceBase<Car>
{
    Task<IEnumerable<Car>> GetAllByMakeIdAsync(int? makeId);
}