//CarName();


//try
//{
//    CarManager carManager = new CarManager(new EfCarDal());
//    foreach (var car in carManager.GetCarDetails())
//    {
//        Console.WriteLine(car.CarId + " - " + car.BrandName + " - " + car.ColorName + " - " + car.DailyPrice);
//    }
//}
//catch (Exception ex)
//{

//    Console.WriteLine($"An error occurred: {ex.Message}");
//}
//static void CarName()
//{
//    CarManager carManager = new CarManager(new EfCarDal());
//    foreach (var car in carManager.GetAllByCarName("bmw"))
//    {
//        Console.WriteLine(car.CarName + "fiyat : " + car.DailyPrice);
//    }
//}
