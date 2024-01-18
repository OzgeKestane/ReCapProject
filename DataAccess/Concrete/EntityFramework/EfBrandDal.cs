using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : IBrandDal
    {
        ReCapContext ctx = new ReCapContext();
        public void Add(Brand entity)
        {

            //using (ReCapContext ctx = new ReCapContext())
            //{
            var addedEntity = ctx.Entry(entity);
            addedEntity.State = EntityState.Added;
            ctx.SaveChanges();
            //}
        }

        public void Delete(Brand entity)
        {

            //using (ReCapContext ctx = new ReCapContext())
            //{
            var deletedEntity = ctx.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            ctx.SaveChanges();
            //}

        }

        public Brand Get(Expression<Func<Brand, bool>> filter)
        {
            //using (ReCapContext ctx = new ReCapContext())
            //{
            return ctx.Set<Brand>().SingleOrDefault(filter);
            //}
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> filter = null)
        {
            //using (ReCapContext ctx = new ReCapContext())
            //{
            return filter == null ? ctx.Set<Brand>().ToList() : ctx.Set<Brand>().Where(filter).ToList();
            //}
        }

        public void Update(Brand entity)
        {
            //using (ReCapContext ctx = new ReCapContext())
            //{
            var updatedEntity = ctx.Entry(entity);
            updatedEntity.State = EntityState.Modified; ctx.SaveChanges();
            //}
        }
    }
}
