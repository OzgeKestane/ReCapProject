using Business.Concrete;
using DataAccess.Concrete.InMemory;

CarManager carManager = new CarManager(new InMemoryCarDal());
foreach (var car in carManager.GetAll())
{
    Console.WriteLine(car.ModelYear + " model " + car.Description + " araba için Günlük Fiyat= " + car.DailyPrice);
}