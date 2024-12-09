﻿// Copyright Information
// ==================================
// AutoLot9 - AutoLot.Dal - IBaseViewRepo.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2024/11/24
// ==================================

namespace AutoLot.Dal.Repos.Interfaces.Base;
public interface IBaseViewRepo<T> : IDisposable where T : class, new()
{
    ApplicationDbContext Context { get; }
    IEnumerable<T> ExecuteSqlString(string sql);
    IEnumerable<T> GetAll();
    IEnumerable<T> GetAllIgnoreQueryFilters();
}