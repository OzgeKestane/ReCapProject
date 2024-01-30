using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dtos;

namespace Business.Abstract
{
    public interface ICarService
    {
        //        Araba ismi minimum 2 karakter olmalıdır

        //Araba günlük fiyatı 0'dan büyük olmalıdır.
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetByCarId(int id);
        IDataResult<List<Car>> GetAllByCarName(string name);
        IDataResult<List<Car>> GetAllByDailyPrice(decimal min);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IResult Add(Car car);
    }
}
