using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetAllByCarId(int id)
        {
            return _carDal.GetAll(c => c.CarId == id);
        }

        public List<Car> GetAllByCarName(string name)
        {
            return _carDal.GetAll(c => c.CarName == name);
        }

        public List<Car> GetAllByDailyPrice(decimal min)
        {
            return _carDal.GetAll(c => c.DailyPrice > 0);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }
    }
}
