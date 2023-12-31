﻿using Final.Domain.Entity;

namespace Final.DAL.Repositories.OrderTimes;

public class OrderTimeRepository : IBaseRepository<OrderTime>
{
    private readonly ApplicationDbContext _db;

    public OrderTimeRepository(ApplicationDbContext db)
    {
        _db = db;
    }
    public async Task<bool> Create(OrderTime entity)
    {
        await _db.OrderTimes.AddAsync(entity);
        await _db.SaveChangesAsync();
        return true;
    }

    public IQueryable<OrderTime> GetAll()
    {
        return _db.OrderTimes;
    }

    public async Task<bool> Delete(OrderTime entity)
    {
        _db.OrderTimes.Remove(entity);
        await _db.SaveChangesAsync();
        return true;
    }

    public async Task<OrderTime> Update(OrderTime entity)
    {
        _db.OrderTimes.Update(entity);
        await _db.SaveChangesAsync();
        return entity;
    }
}
