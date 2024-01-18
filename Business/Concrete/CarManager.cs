using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal = null!;
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
            return _carDal.GetAll(c => c.Id == id);
        }

        public List<Car> GetAllByCarName(string name)
        {
            return _carDal.GetAll(c => c.Name == name);
        }

        public List<Car> GetAllByDailyPrice(decimal min)
        {
            return _carDal.GetAll(c => c.DailyPrice > 0);
        }
    }
}
