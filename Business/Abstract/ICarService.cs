using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICarService
    {
        //        Araba ismi minimum 2 karakter olmalıdır

        //Araba günlük fiyatı 0'dan büyük olmalıdır.
        List<Car> GetAll();
        List<Car> GetAllByCarId(int id);
        List<Car> GetAllByCarName(string name);
        List<Car> GetAllByDailyPrice(decimal min);

    }
}
