using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : IColorDal
    {
        ReCapContext ctx = new ReCapContext();
        public void Add(Color entity)
        {
            //using (ReCapContext ctx = new ReCapContext())
            //{
            var addedEntity = ctx.Entry(entity);
            addedEntity.State = EntityState.Added;
            ctx.SaveChanges();

            // }
        }

        public void Delete(Color entity)
        {
            //using (ReCapContext ctx = new ReCapContext())
            //{
            var deletedEntity = ctx.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            ctx.SaveChanges();
            //}
        }

        public Color Get(Expression<Func<Color, bool>> filter)
        {

            //using (ReCapContext ctx = new ReCapContext())
            //{
            return ctx.Set<Color>().SingleOrDefault(filter);
            //}
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
        {
            //using (ReCapContext ctx = new ReCapContext())
            //{
            return filter == null ? ctx.Set<Color>().ToList() : ctx.Set<Color>().Where(filter).ToList();
            // }
        }

        public void Update(Color entity)
        {
            //using (ReCapContext ctx = new ReCapContext())
            //{
            var updatedEntity = ctx.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            ctx.SaveChanges();
            //}
        }
    }
}
