using Core.DataAccess;
using Entities.Concrete;
using Entities.Dtos;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    public interface IRentalDal : IEntityRepository<Rental>
    {
        List<RentAlDetailDto> GetRentalsDetails(Expression<Func<RentAlDetailDto, bool>> filter = null);
    }
}
