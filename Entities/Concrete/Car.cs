using Core.Entities;

namespace Entities.Concrete
{
    public class Car : IEntity
    {
        public Car(int carId, int brandId, int colorId, string carName, int modelYear, decimal dailyPrice, string description)
        {
            CarId = carId;
            BrandId = brandId;
            ColorId = colorId;
            CarName = carName;
            ModelYear = modelYear;
            DailyPrice = dailyPrice;
            Description = description;
        }
        public Car()
        {

        }

        public int CarId { get; set; }

        public int BrandId { get; set; }
        public int ColorId { get; set; }
        public string CarName { get; set; }

        public int ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; } = null!;
        public Rental? Rentals { get; set; } = null;
    }
}
