using Core.Entities;

namespace Entities.Concrete
{
    public class Rental : IEntity
    {
        public Rental(int rentalId, int carId, int customerId, DateTime rentDate, DateTime returnDate)
        {
            RentalId = rentalId;
            CarId = carId;
            CustomerId = customerId;
            RentDate = rentDate;
            ReturnDate = returnDate;
        }
        public Rental()
        {

        }

        //Id, CarId, CustomerId, RentDate(Kiralama Tarihi), ReturnDate(Teslim Tarihi).
        public int RentalId { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public Car? Cars { get; set; } = null;
        public Customer? Customers { get; set; } = null;
    }
}
