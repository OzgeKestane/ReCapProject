using Core.DataAccesss.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapContext>, IRentalDal
    {
        public List<RentAlDetailDto> GetRentalsDetails(Expression<Func<RentAlDetailDto, bool>> filter = null)
        {
            using (ReCapContext context = new ReCapContext())
            {
                var result = from r in context.Rentals
                             join c in context.Cars
                                 on r.CarId equals c.CarId
                             join cu in context.Customers
                                 on r.CustomerId equals cu.CustomerId
                             join u in context.Users
                                 on cu.UserId equals u.UserId
                             join b in context.Brands
                on c.BrandId equals b.BrandId
                             select new RentAlDetailDto
                             {
                                 RentalId = r.RentalId,
                                 CarName = c.CarName,
                                 CustomerName = cu.CompanyName,
                                 ReturnDate = r.ReturnDate,
                                 RentDate = r.RentDate

                             };
                return filter == null
                    ? result.ToList()
                    : result.Where(filter).ToList();
            }
        }
    }
}
