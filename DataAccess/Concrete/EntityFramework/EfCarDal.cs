﻿using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        //ReCapContext ctx = new ReCapContext();
        public void Add(Car entity)
        {

            using (ReCapContext ctx = new ReCapContext())
            {
                var addedEntity = ctx.Entry(entity);
                addedEntity.State = EntityState.Added;
                ctx.SaveChanges();
            }
        }

        public void Delete(Car entity)
        {
            using (ReCapContext ctx = new ReCapContext())
            {
                var deletedEntity = ctx.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                ctx.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (ReCapContext ctx = new ReCapContext())
            {
                return ctx.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (ReCapContext ctx = new ReCapContext())
            {
                return filter == null ? ctx.Set<Car>().ToList() : ctx.Set<Car>().Where(filter).ToList();
            }
        }

        public void Update(Car entity)
        {
            using (ReCapContext ctx = new ReCapContext())
            {
                var updatedEntity = ctx.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                ctx.SaveChanges();
            }
        }
    }
}
