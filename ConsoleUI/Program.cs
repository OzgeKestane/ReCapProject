using Business.Concrete;
using DataAccess.Concrete.EntityFramework;

CarManager carManager = new CarManager(new EfCarDal());
foreach (var car in carManager.GetAllByCarName("bmw"))
{
    Console.WriteLine(car.Name + "fiyat : " + car.DailyPrice);
}
//ReCapContext reCapContext = new ReCapContext();
//foreach (var item in reCapContext.Cars)
//{
//    Console.WriteLine(item.Name);
//}
//try
//{
//    ReCapContext reCapContext = new ReCapContext();


//    foreach (var item in reCapContext.Cars)
//    {
//        Console.WriteLine(item.Name);
//    }
//}
//catch (Exception ex)
//{

//    Console.WriteLine($"An error occurred: {ex.Message}");
//}
