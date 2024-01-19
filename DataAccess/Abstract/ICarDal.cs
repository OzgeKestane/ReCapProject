using Core.DataAccess;
using Entities.Concrete;
using Entities.Dtos;

namespace DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        //List<Car> GetAll();
        //void Add(Car car);
        //void Delete(Car car);
        //void Update(Car car);
        //List<Car> GetById(int carId);
        List<CarDetailDto> GetCarDetails();
    }
}
