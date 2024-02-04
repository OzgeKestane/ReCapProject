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
        IDataResult<Car> GetByCarId(int id);
        IDataResult<Car> GetByBrandId(int brandId);
        IDataResult<Car> GetByColorId(int colorId);
        IDataResult<List<Car>> GetAllByCarName(string name);
        IDataResult<List<Car>> GetAllByDailyPrice(decimal min);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);
    }
}
